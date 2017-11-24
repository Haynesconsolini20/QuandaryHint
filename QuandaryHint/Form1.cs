﻿using System;
using System.Windows.Forms;
using RawInput_dll;
using System.IO;
using System.ComponentModel;



/************************************
 * TODO LIST
 * Ctrl-f TODO for specific functions
 * Give all the buttons a meaningful name and text
 * Redo the design ffs
 * Reorganize the functions into correct regions
 * Get a previewText and videoText from gameselect
 * Adjust dynaline texts to be on top of screen
 * Make dynaline font slightly smaller
 * Make start/adjust two different buttons
 * Toggle keyboard
 * ***********************************/
namespace QuandaryHint
{
    public partial class Form1 : Form
    { 
        #region Variables
      
        //Holds specific options for each game mode
        public GameOptions inheritOptions;

        //Our configuration window
        private configWin _configWin;

        //Bool connected to a global switch for audio
        private bool audioOn = true;

        //Hint counter
        private int hintCount = 0;

        //Spreadsheet
        Excel excel;
        string excelPath;

        //RawInput
        RawInputKeyboard rawInputKeyboard;
        int cursorPos = 0;
        RawInput rawInput;
        public bool captureOnlyInForeground = false;
        string selectedSource = "void";
        bool TeamEntryFocused = false;

        //Game object where the magic happens
        public Game testGame;

        //background worker to open excel without ruining literally everything
        BackgroundWorker bwExcel = new BackgroundWorker();

        //Timer for introducing to welcome message automatically
        Timer welcomeTimer = new Timer();
       

        #endregion

        #region Constructors
        public Form1(gameSelect gameSel)
        {
            //Start the form
            InitializeComponent();

            
            //Get our game options, then override them if there's a config file
            ParseGameOptions(gameSel.gameOptions);
            ReadConfigFile(ref inheritOptions);

            //Open excel on a seperate thread to speed things up
            bwExcel.DoWork += bwExcel_DoWork;
            bwExcel.RunWorkerAsync();

            //Startup our main class
            testGame = new Game(inheritOptions);

            //Open up the configuration window
            _configWin = new configWin(testGame);

            //TODO: Look into data linking to get rid of this
            audioToggle.Checked = audioOn;

            //Setting up the welcome message timer
            welcomeTimer.Interval = (int)(inheritOptions.timerOffset * 1000);
            welcomeTimer.Tick += new EventHandler(timer_Tick);
            

            #region RawInput setup DO NOT TOUCH
            rawInputKeyboard = new RawInputKeyboard();
            rawInput = new RawInput(Handle, captureOnlyInForeground);
            rawInput.AddMessageFilter();
            hintEntry.Text = "";
            rawInput.KeyPressed += OnKeyPressed;
            #endregion
        }


        #endregion

        #region Config file handling

        /// <summary>
        /// Handles the reading of config file settings into variables. If there isn't one it'll create one for future
        /// use with no data in it.
        /// </summary>
        /// <param name="inheritOptions"></param>
        private void ReadConfigFile(ref GameOptions inheritOptions)
        {
            string configPath = inheritOptions.gameMode + "_config.txt";

            //If there isn't a file
            if (!File.Exists(configPath))
            {
                //Make one with some junk in it
                StreamWriter sw = new StreamWriter(configPath);
                sw.WriteLine("null");
                sw.Close();

                //Find an excel file to edit
                OpenFileDialog opend = new OpenFileDialog();
                DialogResult result = opend.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                    excelPath = opend.FileName;
               
            }
            //If there is...
            else 
            {
                //Open up the file
                StreamReader sr = new StreamReader(configPath);

                //Read in our data
                excelPath = sr.ReadLine();
                inheritOptions.hintFontSize = Int32.Parse(sr.ReadLine());
                inheritOptions.hintVolume = Int32.Parse(sr.ReadLine());
                inheritOptions.gameVolume = Int32.Parse(sr.ReadLine());
                inheritOptions.waveOut = Int32.Parse(sr.ReadLine());
               
            }
        }

        /// <summary>
        /// Write the current settings to a config file whenever we close out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            testGame.WriteConfigFile(excelPath);

        }

        #endregion

        #region Hint Pushing


        /// <summary>
        /// Pushes the hint text to the hint windows, and plays sound if desired
        /// </summary>
        /// <param name="sound"></param>
        private void pushHint(bool sound)
        {
            //Play the sound
            if (audioOn && sound)
                testGame.PlayHint();

           
            //Set the labels
            testGame.SetHintText(hintEntry.Text);

            //Reset the textbox
            hintEntry.Text = "";
            
            //Update the hintcount
            updateHintCount(1);
            
        }

        /// <summary>
        /// Updates the hint count
        /// </summary>
        /// <param name="adjustment"></param>
        private void updateHintCount(int adjustment)
        {
            //Change the hint count
            hintCount += adjustment;

            //Change the ticker
            hintCounter.Value = hintCount;
        }
        #endregion

        #region Keyboard interaction

        /// <summary>
        /// Takes in the RawInputEvent and sends it to be processed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            rawInputKeyboard.ProcessInput(e);
            if (selectedSource == "void" || selectedSource == rawInputKeyboard.source)
            {
                if (!captureOnlyInForeground)
                {
                    if (TeamEntryFocused)
                        HandleInput(rawInputKeyboard.processed, TeamNameEntry);
                    else
                        HandleInput(rawInputKeyboard.processed, hintEntry);
                }
            }

        }

        /// <summary>
        /// Turns rawinput into meaningful text entry
        /// </summary>
        /// <param name="output"></param>
        void HandleInput(string output, TextBox hintEntry)
        {


            if (output == "SPACE")
            {
                hintEntry.Text += " ";
                cursorPos += 2;
                hintEntry.SelectionStart = cursorPos;
            }
            else if (output == "BACKSPACE")
            {
                if (hintEntry.Text.Length > 0)
                    hintEntry.Text = hintEntry.Text.Remove(hintEntry.Text.Length - 1);
                cursorPos -= 2;
                if (cursorPos < 0)
                {
                    cursorPos = 0;
                }
                hintEntry.SelectionStart = cursorPos;
            }
            else if (output == "CTRLk")
            {
                selectedSource = rawInputKeyboard.source;
            }
            else if (output == "CTRLr")
            {
                hintEntry.Text = "";
                pushHint(false);
                cursorPos = 0;

                //This is to compensate for the pushHint upping it one
                updateHintCount(-1);

                hintEntry.SelectionStart = 0;
            }
            else if (output == "CTRLa")
            {
                hintEntry.SelectAll();
            }
            else if (output == "SHIFTenter")
            {
                pushHint(false);
            }
            else if (output == "CTRLw")
            {
                hintEntry.Text = inheritOptions.welcomeMessage;
                pushHint(false);
                hintCount = 0;

                //Compensate for pushHint
                updateHintCount(0);

            }

            else if (output == "ENTER")
            {
                pushHint(true);
                hintEntry.Text = "";
                cursorPos = 0;
                hintEntry.SelectionStart = cursorPos;
            }
            else if (output != "void")
            {
                hintEntry.Text += output;
                cursorPos += 2;
                hintEntry.SelectionStart = cursorPos;
                if (this.hintEntry.Text != "")
                    testGame.DecoderMessage();
            }

        }


        #endregion

        #region Misc Private methods

        /// <summary>
        /// When the timer hits the tick(start of the game), it displays the
        /// welcome message and then stops the timer so we can use it next
        /// round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            testGame.SetHintText(inheritOptions.welcomeMessage);
            welcomeTimer.Stop();
        }

        /// <summary>
        /// Parses the game mode information from the first window
        /// </summary>
        /// <param name="game"></param>
        private void ParseGameOptions(GameOptions game)
        {
            inheritOptions.welcomeMessage = game.welcomeMessage;
            inheritOptions.videoPath = game.videoPath;
            inheritOptions.hintFont = game.hintFont;
            inheritOptions.gameMode = game.gameMode;
            inheritOptions.fontColor = game.fontColor;
            inheritOptions.audioPath = game.audioPath;
            inheritOptions.timerOffset = game.timerOffset;
            inheritOptions.previewFont = game.previewFont;
            inheritOptions.gameColumn = game.gameColumn;
            inheritOptions.gameVolume = game.gameVolume;
            inheritOptions.hintVolume = game.hintVolume;
            inheritOptions.videoOffset = game.videoOffset;
            inheritOptions.hintFontSize = game.hintFontSize;
        }

        /// <summary>
        /// Background worker1's task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            excel = new Excel(excelPath, 1, inheritOptions.gameColumn);
        }

        #endregion

        #region Clicking events

        /// <summary>
        /// Pushes the hint with sound, just in case the keyboard doesn't work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HintPusher_Click(object sender, EventArgs e)
        {
            pushHint(true);
        }
    
        /// <summary>
        /// Shows the configuration window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void configButton_Click(object sender, EventArgs e) => _configWin.Show();

        /// <summary>
        /// Toggles hint audio on and off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void audioToggle_CheckStateChanged(object sender, EventArgs e)
        {
            audioOn = audioToggle.Checked;
        }

        /// <summary>
        /// Begins a round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartVideoBtn_Click(object sender, EventArgs e)
        {
            testGame.StartGame();
            welcomeTimer.Start();
            Console.WriteLine("Timer started");
        }

        /// <summary>
        /// Aligns the hint windows to their videos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlignHintsBtn_Click(object sender, EventArgs e)
        {
            testGame.AlignHintWindows();
        }
       
        /// <summary>
        /// Toggles the paused state of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayPauseBtn_Click(object sender, EventArgs e)
        {
            testGame.TogglePaused();
            label3.Text = testGame.GetEscapeTime();
        }

        /// <summary>
        /// Manually updates the hint count for the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hintCounter_ValueChanged(object sender, EventArgs e)
        {
            hintCount = (int)hintCounter.Value;
            updateHintCount(0);
        }

        /// <summary>
        /// Plays the hint sound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HintSoundBtn_Click(object sender, EventArgs e)
        {
            testGame.PlayHint();
        }

        /// <summary>
        /// Calls the escape method and sets the label to the escape time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EscapeBtn_Click(object sender, EventArgs e)
        {
           
            testGame.Escape();
            Console.WriteLine("Escape method");
            label3.Text = testGame.GetEscapeTime();
            Console.WriteLine("get escape time");

            excel.AppendToDocument((int)TeamSizeEntry.Value, TeamNameEntry.Text, testGame.GetEscapeTime(), true);
            TeamNameEntry.Text = "blank";
            TeamSizeEntry.Value = 0;
            testGame.SetHintText("");
            
            Console.WriteLine("appended to doc");
        }

        /// <summary>
        /// Does all the initial setup gruntwork
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void easyStartBtn_Click(object sender, EventArgs e)
        {
            testGame.SetupGameWindow();
        }

        /// <summary>
        /// Resets the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            testGame.ResetGame();
            if (TeamSizeEntry.Value > 0)
                excel.AppendToDocument((int)TeamSizeEntry.Value, TeamNameEntry.Text, "0", false);
            TeamNameEntry.Text = "blank";
            TeamSizeEntry.Value = 0;
            label3.Text = "Escape Time";
            testGame.SetHintText("");

            Console.WriteLine("appended to doc");
        }

        /// <summary>
        /// Toggles whether or not RawInput gets passed the the processor function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CaptureInputCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (captureOnlyInForeground)
                captureOnlyInForeground = false;
            else
                captureOnlyInForeground = true;
        }

        

      


       
        

        /// <summary>
        /// Brings the RawInput events to the team entry text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeamNameEntry_Click(object sender, EventArgs e)
        {
            TeamEntryFocused = true;
            if (TeamNameEntry.Text == "blank")
                TeamNameEntry.Text = "";

        }

        /// <summary>
        /// Brings the RawInput events to the hint entry text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hintEntry_Click(object sender, EventArgs e)
        {
            TeamEntryFocused = false;
        }


        #endregion
    }
}
