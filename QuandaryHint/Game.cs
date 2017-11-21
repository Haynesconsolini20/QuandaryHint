

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

        private bool paused = false;

        private GameOptions gameOptions;
        #endregion 



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

        /// <summary>
        /// Passes on the values from the passed struct to appropriate
        /// local variables
        /// </summary>
        /// <param name="game"></param>
        private void ParseGameOptions(GameOptions game)
        {
            gameOptions.welcomeMessage = game.welcomeMessage;
            // gameOptions.videoPath = game.videoPath;
            
            gameOptions.hintFont = game.hintFont;
            gameOptions.gameMode = game.gameMode;
            gameOptions.fontColor = game.fontColor;
            // gameOptions.audioPath = game.audioPath;
            gameOptions.timerOffset = game.timerOffset;
            gameOptions.gameMode = game.gameMode;
            gameOptions.videoPath = game.videoPath;
            gameOptions.audioPath = game.audioPath;
            gameVideo.SetPath(game.videoPath);
            gameVideo.videoOffset = game.videoOffset;
            previewVideo.SetPath(game.videoPath);
            previewVideo.videoOffset = game.videoOffset;
           
                
            gameOptions.previewFont = game.previewFont;
            // VIDEO_OFFSET = game.videoOffset;
            // hintSound.SetPlayerVolume(game.hintVolume, game.hintVolume);
            //  gameSound.SetPlayerVolume(game.gameVolume, game.gameVolume);

            hintSound.SetVolume(game.hintVolume);

            videoSound.SetVolume(game.gameVolume);
            videoSound.SetPath(game.audioPath);

            gameHint.CopyGameOptions(game);
            previewHint.CopyGameOptions(game);
        }

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
            if (seconds < 10)
                sec = "0" + (int)seconds;
            else
                sec = ((int)seconds).ToString();

           escape = (int)minutes + ":" + sec;



            return escape;
        }
      

        /// <summary>
        /// Plays the sound for pushing hints
        /// </summary>
        public void PlayHint() => hintSound.StartPlayback();

        /// <summary>
        /// Sets the game video up properly on the monitor
        /// </summary>
        public void SetupGameWindow()
        {
            gameVideo.AdjustVideo();
            gameVideo.ToggleBorder();
            SetupHintWindows();
            AlignHintWindows();
        }

        #region Game State Methods
        /// <summary>
        /// Starts up the video/audio
        /// </summary>
        public void StartGame()
        {
            gameVideo.StartPlayback();
            videoSound.StartPlayback();
            previewVideo.StartPlayback();
           
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
        }

        /// <summary>
        /// Toggles the pausing of the video and audio
        /// </summary>
        public void TogglePaused()
        {
            if (!paused)
            {
                PauseGame();
                gameVideo.UpdatePlaybackPosition();
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
            PauseGame();
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



      

     

        
    }
}
