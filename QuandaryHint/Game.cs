using System.IO;

namespace QuandaryHint
{
    public class Game
    {
        #region Variables

        
        public Audio videoSound;
        public Audio hintSound;

        public Video gameVideo;
        public Video previewVideo;

        public Hint gameHint;
        public Hint previewHint;

        //Holds the pause state of the game
        private bool paused = false;

        //A struct to hold game mode information
        public GameOptions gameOptions;

        //Index of the desired waveout device
        public uint waveOutIndex;

        #endregion

        #region Constructors
        /// <summary>
        /// Non-default constructor that takes a GameOptions parameter
        /// </summary>
        /// <param name="gameOpt"></param>
        public Game(GameOptions gameOpt)
        {
            gameHint = new Hint(false);
            previewHint = new Hint(true);

            hintSound = new Audio();
            hintSound.SetPath(@"assets\hintSound.wav");

            videoSound = new Audio();

            gameVideo = new Video("Game Window");
            previewVideo = new Video("Preview Window");


            ParseGameOptions(gameOpt);


            gameVideo.DisplayFrame();
            previewVideo.DisplayFrame();

            
        }
        #endregion

        #region Game setup
        /// <summary>
        /// Passes on the values from the passed struct to appropriate
        /// local variables
        /// </summary>
        /// <param name="game"></param>
        private void ParseGameOptions(GameOptions game)
        {
            //10 here is a placeholder value to indicate that there is no waveout device selected
            //In theory this breaks if there are 10 sound outputs on a single computer..but I'm
            //counting on that not happening
            if (gameOptions.waveOut != 10)
                SetAudioOutput((uint)game.waveOut);

            //Copying of the struct
            gameOptions.welcomeMessage = game.welcomeMessage;
            gameOptions.hintFont = game.hintFont;
            gameOptions.gameMode = game.gameMode;
            gameOptions.fontColor = game.fontColor;
            gameOptions.hintFontSize = game.hintFontSize;
            gameOptions.timerOffset = game.timerOffset;
            gameOptions.gameMode = game.gameMode;
            gameOptions.videoPath = game.videoPath;
            gameOptions.audioPath = game.audioPath;
            gameOptions.previewFont = game.previewFont;


            //Setup the video classes
            gameVideo.SetPath(game.videoPath);
            gameVideo.videoOffset = game.videoOffset;
            previewVideo.SetPath(game.videoPath);
            previewVideo.videoOffset = game.videoOffset;
           
            //Setup the audio classes
            hintSound.SetVolume(game.hintVolume);
            videoSound.SetVolume(game.gameVolume);
            videoSound.SetPath(game.audioPath);

            //Another function to setup hint classes
            gameHint.CopyGameOptions(game);
            previewHint.CopyGameOptions(game);
        }

        /// <summary>
        /// Sets the game video up properly on the monitor
        /// </summary>
        public void SetupGameWindow()
        {
            gameVideo.AdjustVideo();
            gameVideo.ToggleBorder();
            SetupHintWindows();
            AlignHintWindows();
            ResetGame();
        }
        #endregion

        #region Audio handling
        /// <summary>
        /// Sets the waveout device for the audio objects
        /// </summary>
        /// <param name="i"></param>
        public void SetAudioOutput(uint i)
        {
            videoSound.SetAudioOutput(i);
            hintSound.SetAudioOutput(i);
            waveOutIndex = i;
        }

        /// <summary>
        /// Plays the sound for pushing hints
        /// </summary>
        public void PlayHint() => hintSound.StartPlayback();
        #endregion

        #region Game State Methods
        /// <summary>
        /// Starts up the video/audio
        /// </summary>
        public void StartGame()
        {
            gameVideo.SetPosition(0.0, 1.0);
            previewVideo.SetPosition(0.0, 1.0);
            videoSound.SetPosition(0, 1);

            gameVideo.ResumePlayback();
            videoSound.ResumePlayback();
            previewVideo.ResumePlayback();
            /*
            gameVideo.StartPlayback();
            videoSound.StartPlayback();
            previewVideo.StartPlayback();
           */
        }

        /// <summary>
        /// Resumes video/audio
        /// </summary>
        public void ResumeGame()
        {
            gameVideo.ResumePlayback();
            videoSound.ResumePlayback();
            previewVideo.ResumePlayback();
        }

        /// <summary>
        /// Pauses the video/audio
        /// </summary>
        public void PauseGame()
        {
            gameVideo.PausePlayback();
            previewVideo.PausePlayback();
            videoSound.PausePlayback();
            gameVideo.UpdatePlaybackPosition();
        }

        /// <summary>
        /// Rewinds the video/audio
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void RewindGame(double minutes, double seconds)
        {
            gameVideo.Rewind(minutes, seconds);
            previewVideo.Rewind(minutes, seconds);
            videoSound.Rewind(minutes, seconds);
        }

        /// <summary>
        /// Fast forwards the video/audio
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void FastForward(double minutes, double seconds)
        {
            gameVideo.FastForward(minutes, seconds);
            previewVideo.FastForward(minutes, seconds);
            videoSound.FastForward(minutes, seconds);
        }

        /// <summary>
        /// Toggles the pausing of the video and audio
        /// </summary>
        public void TogglePaused()
        {
            gameVideo.UpdatePlaybackPosition();
            if (!paused)
            {
                PauseGame();
                
                paused = true;
               
            }
            else
            {
                ResumeGame();
                paused = false;
            }

        }

        /// <summary>
        /// Pauses the video, plays victory video for Dynaline games
        /// </summary>
        public void Escape()
        {
            TogglePaused();
            if (gameOptions.gameMode == "The Psych Ward")
            {
                gameVideo.SetPath(@"C:\DI_Victory.wmv");
                previewVideo.SetPath(@"C:\DI_Victory.wmv");
                videoSound.SetPath(@"assets\DI_Victory.mp3");
                StartGame();
            }
        }

        /// <summary>
        /// Resets the file paths and displays the starter frame
        /// </summary>
        public void ResetGame()
        {
            PauseGame();

            gameVideo.SetPath(gameOptions.videoPath);
            previewVideo.SetPath(gameOptions.videoPath);
            videoSound.SetPath(gameOptions.audioPath);

            gameVideo.DisplayFrame();
            previewVideo.DisplayFrame();
        }
        #endregion

        #region Hint window methods

        /// <summary>
        /// Sets the hint text of both windows
        /// </summary>
        /// <param name="text"></param>
        public void SetHintText(string text)
        {
            gameHint.SetHint(text);
            previewHint.SetHint(text);
        }

        /// <summary>
        /// Message to be displayed while typing a hint
        /// </summary>
        public void DecoderMessage()
        {
            SetHintText("Decoding Hint...\n\n");
        }

        /// <summary>
        /// Toggles the hint borders
        /// </summary>
        private void ToggleHintBorders()
        {
            gameHint.ToggleBorder();
            previewHint.ToggleBorder();

        }

        /// <summary>
        /// Sets the hint windows at the same location as the video counterparts
        /// </summary>
        public void AlignHintWindows()
        {
            gameHint.SetLocation(gameVideo.GetLocation());
            previewHint.SetLocation(previewVideo.GetLocation());
        }

        /// <summary>
        /// Sets the hint windows to the size of the video counterparts
        /// </summary>
        private void ResizeHintWindows()
        {
            gameHint.SetSize(gameVideo.GetSize());
            previewHint.SetSize(previewVideo.GetSize());
        }

        /// <summary>
        /// Sets up the hint windows for use using private methods
        /// </summary>
        private void SetupHintWindows()
        {
            ToggleHintBorders();
            AlignHintWindows();
            ResizeHintWindows();

            gameHint.ShowWindow();
            previewHint.ShowWindow();
            
        }

        #endregion

        #region Misc 
        /// <summary>
        /// Returns the current escape time as a string
        /// </summary>
        /// <returns></returns>
        public string GetEscapeTime()
        {
            string escape;

            double minutes = (gameVideo.GetPlaybackPosition() - gameOptions.timerOffset) / 60;
            double seconds = (gameVideo.GetPlaybackPosition() - gameOptions.timerOffset) % 60;
            string sec;

            //Make sure seconds under 10 are formatted correctly
            if (seconds < 10)
                sec = "0" + (int)seconds;
            else
                sec = ((int)seconds).ToString();

            escape = (int)minutes + ":" + sec;



            return escape;
        }

        /// <summary>
        /// Writes the excel path, volumes, and audio output device to a text file
        /// that will be read upon future startups
        /// </summary>
        /// <param name="excelPath"></param>
        public void WriteConfigFile(string excelPath)
        {
            StreamWriter sw = new StreamWriter(gameOptions.gameMode + "_config.txt");
            //excel path
            sw.WriteLine(excelPath);
            //font size
            sw.WriteLine(gameHint.hintWindowFont);
            //hint volume
            sw.WriteLine(hintSound.volume);
            //video volume
            sw.WriteLine(videoSound.volume);
            //Audio output device
            sw.WriteLine(waveOutIndex);

            sw.Close();
        }
        #endregion
    }
}
