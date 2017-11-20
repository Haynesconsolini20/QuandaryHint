using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
using libZPlay;
using RawInput_dll;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;



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
        public int hintVolume;
        public int gameVolume;

        //The offset for the video so that it syncs with the audio. Seems to be about .5 per video playing
        public double VIDEO_OFFSET = 1000.900;

        //This holds the position while the video is "paused". I actually have to stop the video
        //because the pause function literally does nothing.
        public double playbackPosition = 0;
        public GameOptions inheritOptions;

        //Our hint window
        private hintWindow _hintWin;
        private hintWindow _previewWin;

       
        //Our configuration window
        private configWin _configWin;

        //Bool connected to a global switch for audio
        private bool audioOn = true;

        //Hint counter
        private int hintCount = 0;

        //For the decoder text effect
        bool firstPress = true;

        //RawInput
        RawInputKeyboard rawInputKeyboard;
        int cursorPos = 0;
        RawInput rawInput;
        public bool captureOnlyInForeground = false;
        string selectedSource = "void";

        //Audio objects
        public ZPlay zplayer;
        public ZPlay videoSound;

        //Video objects
        public videoPane video;
        public videoPane previewVideo;
        

#endregion

        public Form1(hintWindow hintWin, gameSelect gameSel)
        {
            InitializeComponent();

            #region Initialize other windows
            zplayer = new ZPlay();
            videoSound = new ZPlay();


            //Initialize both hint windows
            _hintWin = new hintWindow();
            _previewWin = new hintWindow();

            //Get the game select options, and put them into the windows
            ParseGameOptions(gameSel.gameOptions);
            CopyGameOptions(_hintWin, false);
            CopyGameOptions(_previewWin, true);
            
            //Initialize config window
            _configWin = new configWin(_hintWin, this);
            _previewWin.hintLabel.Font = inheritOptions.previewFont;

            
            //Initialize video windows
            video = new videoPane();
            previewVideo = new videoPane();
            video.Text = "Game window";
            previewVideo.Text = "Preview window";
            

            #endregion

            #region Starting up objects and good morning methods

            //TODO: Look into data linking to get rid of this
            audioToggle.Checked = audioOn;

            //Helps to reduce flickering with the transparency
            SetDoubleBuffered(_hintWin);

            //Audio objects
            
            videoSound.OpenFile(inheritOptions.audioPath, TStreamFormat.sfAutodetect);
            #endregion

            #region RawInput setup DO NOT TOUCH
            rawInputKeyboard = new RawInputKeyboard();
            rawInput = new RawInput(Handle, captureOnlyInForeground);
            rawInput.AddMessageFilter();
            hintEntry.Text = "";
            rawInput.KeyPressed += OnKeyPressed;
            #endregion
        }


        #region Hint Pushing
        /***************************************************
         * playAudio
         * Plays a sound for the hint push
         ****************************************************/
        private void playAudio()
        {
            zplayer.OpenFile("hintSound.wav", TStreamFormat.sfAutodetect);
            zplayer.StartPlayback(); 
        }

        /**************************************************
         * pushHint
         * Pushes a hint, with optional sound
         * ***********************************************/
        private void pushHint(bool sound)
        {
            if (audioOn)
            {
                if (sound)
                    playAudio();
            }
      
            //Actual setting of the labels
            _hintWin.hintLabel.Text = hintEntry.Text;
            _previewWin.hintLabel.Text = _hintWin.hintLabel.Text;

            //Reset the textbox
            hintEntry.Text = "";
            
            //Update the hintcount
            updateHintCount(1);

            //We are no longer decoding a hint
            firstPress = true;
        }

        private void updateHintCount(int adjustment)
        {
            //Change the hint count
            hintCount += adjustment;

            //Change the ticker
            hintCounter.Value = hintCount;
        }
        #endregion

        #region Redundancy Controls
        /************************************************************
         * button1_Click
         * Pushing of the "Push hint" button pushes a hint
         * **********************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            pushHint(true);
        }
    
        /************************************************************
         * hintToggler_Click
         * Clicking of the "Toggle border" btn toggles the hintwin style
         ************************************************************/
        private void hintToggler_Click(object sender, EventArgs e)
        {
            ToggleHintBorder();
        }
        #endregion

        private void ToggleHintBorder()
        {

            if (_hintWin.FormBorderStyle == System.Windows.Forms.FormBorderStyle.Sizable)
            {
                _hintWin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                _previewWin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            }
            else
            {
                _hintWin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                _previewWin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }
        #region Window buttons
        /***********************************************************
         * showHintWin_Click
         * Shows the hintwindow if it got closed
         * *********************************************************/
        private void showHintWin_Click(object sender, EventArgs e)
        {
            _hintWin.Show();
        }
        /*************************************************************
         * configButton_Click
         * Opens the configuration window
         ************************************************************/
        private void configButton_Click(object sender, EventArgs e) => _configWin.Show();


        #endregion

        #region Keyboard interaction
        
        /**************************************************
         * OnKeyPressed
         * Takes in the RawInputEvent and sends it to be processed
         * **********************************************************/
        private void OnKeyPressed(object sender, RawInputEventArg e)
        {
            rawInputKeyboard.ProcessInput(e);
            if (selectedSource == "void" || selectedSource == rawInputKeyboard.source)
            {
                if (!captureOnlyInForeground)
                    HandleInput(rawInputKeyboard.processed);
            }
                
        }

        /***************************************
         * HandleInput
         * Turns raw input into meaningful text entry
         * ****************************************/
        void HandleInput(string output)
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
                _configWin.configKB.Text = selectedSource;
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
            else if (output == "CTRLp")
            {

                PauseGame();
            }
            else if (output == "CTRLa")
            {
                hintEntry.SelectAll();
            }
            else if (output == "CTRLb")
            {
                if (_hintWin.FormBorderStyle == System.Windows.Forms.FormBorderStyle.Sizable)
                {
                    _hintWin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                }
                else
                {
                    _hintWin.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                }
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
                //DecoderMessage();
                //string initialDecode = "Decoding Hint...\n\n";
                otherDecode(_hintWin);
                otherDecode(_previewWin);
                


            }

        }

        private void otherDecode(hintWindow hint)
        {
            hint.hintLabel.Text = "Decoding Hint...\n\n";
        }
        /***************************************
         * DecoderMessage
         * Creates the "decoding message" effect
         * ****************************************/
        private void DecoderMessage()
        {
            string initialDecode = "Decoding Hint...\n\n";
            if (firstPress)
            {
                for (int i = 0; i < 200; i++)
                {
                    if (i % 2 == 0)
                        initialDecode += "░";
                    else
                        initialDecode += "▓";
                }

                _hintWin.hintLabel.Text = initialDecode;
                firstPress = false;
            }

           
            Random rand = new Random();
            char[] weirdChars = "░▓▒▒".ToCharArray();
            char [] charArr = _hintWin.hintLabel.Text.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                charArr[rand.Next(18, 217)] = weirdChars[rand.Next(1, 4)];
                System.Threading.Thread.Sleep(1);
            }
            _hintWin.hintLabel.Text = new string(charArr);
            _previewWin.hintLabel.Text = new string(charArr);
            

        }
        #endregion

        #region Misc methods
        /******************************************************************
         * DoubleBuffer
         * Prevents hintwindow from flickering so much
         * ****************************************************************/
        public static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            //Taxes: Remote Desktop Connection and painting
            //http://blogs.msdn.com/oldnewthing/archive/2006/01/03/508694.aspx
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }
        #endregion

        #region Other control events
        /**********************************************************************
         * audioToggle
         * Turns global audio on or off
         * *******************************************************************/
        private void audioToggle_CheckStateChanged(object sender, EventArgs e)
        {
            audioOn = audioToggle.Checked;
        }

        

        
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenVideo();
        }

        private void OpenVideo()
        {
            //Set the windows to the correct filepath
            previewVideo.axWindowsMediaPlayer1.URL = inheritOptions.videoPath;
            video.axWindowsMediaPlayer1.URL = inheritOptions.videoPath;

            //Display the windows
            video.Show();
            previewVideo.Show();
        }
        #endregion

        private void ToggleVideoBorder()
        {
            toggleVideoBorder(video);
            toggleVideoBorder(previewVideo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleVideoBorder();
        }

        private void toggleVideoBorder(videoPane video)
        {
            if (video.FormBorderStyle == System.Windows.Forms.FormBorderStyle.None)
            {
                video.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
            else
                video.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            StartVideo();
        }


        private void StartVideo()
        { 
            if (video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition > VIDEO_OFFSET)
            {
                videoSound.StopPlayback();
            }


            //Starting the game-room video
            video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = VIDEO_OFFSET;
            video.axWindowsMediaPlayer1.Ctlcontrols.play();
            videoSound.StartPlayback();

            //Housekeeping settings for the game-room video
            
            video.axWindowsMediaPlayer1.settings.mute = true;

            //Starting the employee monitor video
            previewVideo.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = VIDEO_OFFSET;
            previewVideo.axWindowsMediaPlayer1.Ctlcontrols.play();
            previewVideo.axWindowsMediaPlayer1.settings.mute = true;

           
        }

        private void AdjustVideo()
        {
            video.WindowState = FormWindowState.Maximized;
            video.axWindowsMediaPlayer1.Size = new System.Drawing.Size(video.Width, video.Height);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlignHintWindows();
        }
        
        private void AlignHintWindows()
        {
            _hintWin.Show();
            _hintWin.Location = video.Location;
            _hintWin.Size = video.Size;

            _previewWin.Show();
            _previewWin.Location = previewVideo.Location;
            _previewWin.Size = previewVideo.Size;

            /*string fontName = _hintWin.hintLabel.Font.Name;
            float fontSize = (float)40.0;
            System.Drawing.Font newFont = new Font(fontName, fontSize);
            _hintWin.hintLabel.Font = newFont;*/
        }

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
            VIDEO_OFFSET = game.videoOffset;
            zplayer.SetPlayerVolume(game.hintVolume, game.hintVolume);
            videoSound.SetPlayerVolume(game.gameVolume, game.gameVolume);
            gameVolume = game.gameVolume;
            hintVolume = game.hintVolume;


            

        }

        private void CopyGameOptions(hintWindow hint, bool preview)
        {
            
            hint.hintLabel.Font = inheritOptions.hintFont;

            hint.hintLabel.ForeColor = inheritOptions.fontColor;
            hint.Text = inheritOptions.gameMode;
            hint.Text = inheritOptions.gameMode + " Hints";

            if (inheritOptions.gameMode == "The Psych Ward")
            {
                hint.hintLabel.TextAlign = ContentAlignment.TopCenter;
                if (!preview)
                     hint.hintLabel.Padding = new Padding(0, 50, 0, 0);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            PauseGame();
        }

        private void CalculateTimeRemaining()
        {
            
            double minutes = (playbackPosition - inheritOptions.timerOffset) / 60;
            double seconds = (playbackPosition - inheritOptions.timerOffset) % 60;
            string sec;
            if (seconds < 10)
                sec = "0" + (int)seconds;
            else
                sec = ((int)seconds).ToString();

            label3.Text = (int)minutes + ":" + sec;

        }


        private void PauseGame()
        {
            
            
            if (playbackPosition == 0)
            {
                playbackPosition = video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                // video.axWindowsMediaPlayer1.Ctlcontrols.stop();
                //previewVideo.axWindowsMediaPlayer1.Ctlcontrols.stop();
                video.axWindowsMediaPlayer1.Ctlcontrols.pause();
                previewVideo.axWindowsMediaPlayer1.Ctlcontrols.pause();
                videoSound.PausePlayback();

                CalculateTimeRemaining();
            }
            else
            {
              //  video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = playbackPosition;
              //  previewVideo.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = playbackPosition;
                video.axWindowsMediaPlayer1.Ctlcontrols.play();
                previewVideo.axWindowsMediaPlayer1.Ctlcontrols.play();
                videoSound.ResumePlayback();
                playbackPosition = 0;
            }

        }

        private void hintCounter_ValueChanged(object sender, EventArgs e)
        {
            hintCount = (int)hintCounter.Value;
            updateHintCount(0);
        }

        private void adjustBtn_Click(object sender, EventArgs e)
        {
            AdjustVideo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            playAudio();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            PauseGame();
            videoSound.StopPlayback();
            if (inheritOptions.gameMode == "The Psych Ward")
            {
                video.axWindowsMediaPlayer1.URL = @"C:\DI_Victory.wmv";
                video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = VIDEO_OFFSET;
                videoSound.OpenFile("DI_Victory.wmv", TStreamFormat.sfAutodetect);

                previewVideo.axWindowsMediaPlayer1.URL = @"C:\DI_Victory.wmv";
                previewVideo.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = VIDEO_OFFSET;

                previewVideo.axWindowsMediaPlayer1.Ctlcontrols.play();
                video.axWindowsMediaPlayer1.Ctlcontrols.play();
                videoSound.StartPlayback();

               
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            video.axWindowsMediaPlayer1.Ctlcontrols.pause();
            previewVideo.axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void easyStartBtn_Click(object sender, EventArgs e)
        {
            AdjustVideo();
            ToggleVideoBorder();
            AlignHintWindows();
            ToggleHintBorder();
        }
    }
}
