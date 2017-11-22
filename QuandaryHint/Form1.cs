using System;
using System.Windows.Forms;
using RawInput_dll;
using System.Drawing;
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
       

        #endregion

        #region Constructors
        public Form1(hintWindow hintWin, gameSelect gameSel)
        {
            InitializeComponent();


            ParseGameOptions(gameSel.gameOptions);
            ReadConfigFile(ref inheritOptions);


            bwExcel.DoWork += bwExcel_DoWork;
            
            bwExcel.RunWorkerAsync();

            //Get the game select options, and put them into the windows
            Console.WriteLine("Pre game volume: " + inheritOptions.gameVolume);
            testGame = new Game(inheritOptions);
            _configWin = new configWin(testGame);



            //Initialize config window


            //TODO: Look into data linking to get rid of this
            audioToggle.Checked = audioOn;

            

            #region RawInput setup DO NOT TOUCH
            rawInputKeyboard = new RawInputKeyboard();
            rawInput = new RawInput(Handle, captureOnlyInForeground);
            rawInput.AddMessageFilter();
            hintEntry.Text = "";
            rawInput.KeyPressed += OnKeyPressed;
            #endregion
        }

       
        #endregion

        private void ReadConfigFile(ref GameOptions inheritOptions)
        {


            string configPath = inheritOptions.gameMode + "_config.txt";

            Console.WriteLine("Checking for file...");
            if (!File.Exists(configPath))
            {
                Console.WriteLine("File does not exist. Creating it..");
                StreamWriter sw = new StreamWriter(configPath);
                sw.WriteLine("null");
                sw.Close();

                OpenFileDialog opend = new OpenFileDialog();
                DialogResult result = opend.ShowDialog(); // Show the dialog.
                if (result == DialogResult.OK) // Test result.
                    excelPath = opend.FileName;
               
            }
            else
            {
                Console.WriteLine("File exists. Parsing data..");
                StreamReader sr = new StreamReader(configPath);

                excelPath = sr.ReadLine();
                inheritOptions.hintFontSize = Int32.Parse(sr.ReadLine());
                inheritOptions.hintVolume = Int32.Parse(sr.ReadLine());
                inheritOptions.gameVolume = Int32.Parse(sr.ReadLine());
                inheritOptions.waveOut = Int32.Parse(sr.ReadLine());
                //audio output

                Console.WriteLine("Game volume is " + inheritOptions.gameVolume);
            }
       
           

        }

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

        #region Event Handlers

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
        private void StartVideoBtn_Click(object sender, EventArgs e) => testGame.StartGame();

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
        /// Background worker1's task
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bwExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            excel = new Excel(excelPath, 1, inheritOptions.gameColumn);
        }

      


        #endregion
        


        private void TeamNameEntry_Click(object sender, EventArgs e)
        {
            TeamEntryFocused = true;
            if (TeamNameEntry.Text == "blank")
                TeamNameEntry.Text = "";

        }

        private void hintEntry_Click(object sender, EventArgs e)
        {
            TeamEntryFocused = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            testGame.WriteConfigFile(excelPath);

        }
    }
}
