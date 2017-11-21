using libZPlay;

namespace QuandaryHint
{
    public class Audio
    {
        //The variable that this wrapper is for
        private ZPlay sound;

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public Audio()
        {
            sound = new ZPlay();
        }

        /// <summary>
        /// Non-default constructor with path and volume
        /// </summary>
        /// <param name="path"></param>
        /// <param name="volume"></param>
        public Audio(string path, int volume)
        {
            sound = new ZPlay();
            SetPath(path);
            SetVolume(volume);
        }

        /// <summary>
        /// Non-default constructor with just path
        /// </summary>
        /// <param name="path"></param>
        public Audio(string path)
        {
            sound = new ZPlay();
            SetPath(path);
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Set the filepath for the sound player
        /// </summary>
        /// <param name="path"></param>
        public void SetPath(string path) => sound.OpenFile(path, TStreamFormat.sfAutodetect);

        /// <summary>
        /// Set the volume for both sides equally
        /// </summary>
        /// <param name="volume"></param>
        public void SetVolume(int volume)
        {
            if (volume <= 10)
                volume *= 10;
            sound.SetPlayerVolume(volume, volume);
        }

        /// <summary>
        /// Begin playback
        /// </summary>
        public void StartPlayback()
        {
            TStreamStatus status = new TStreamStatus();
            sound.GetStatus(ref status);

            if (status.fPlay == true)
            {
                sound.StopPlayback();
            }

            sound.StartPlayback();
        }

        /// <summary>
        /// Stop playback
        /// </summary>
        public void StopPlayback() => sound.StopPlayback();

        /// <summary>
        /// Pauses playback
        /// </summary>
        public void PausePlayback() => sound.PausePlayback();

        /// <summary>
        /// Resumes playback
        /// </summary>
        public void ResumePlayback() => sound.ResumePlayback();

        /// <summary>
        /// Fast forwards the sound a specified duration
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void FastForward(int minutes, int seconds)
        {
            TStreamTime time = new TStreamTime();
            time.sec = (uint)ComputeSeconds(minutes, seconds);

            sound.Seek(TTimeFormat.tfSecond, ref time, TSeekMethod.smFromCurrentForward);
        }

        /// <summary>
        /// Rewinds the sound a specified duration
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void Rewind(int minutes, int seconds)
        {
            TStreamTime time = new TStreamTime();
            time.sec = (uint)ComputeSeconds(minutes, seconds);

            sound.Seek(TTimeFormat.tfSecond, ref time, TSeekMethod.smFromCurrentBackward);
        }

        /// <summary>
        /// Sets the sound to a certain position in it's playback
        /// </summary>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        public void SetPosition(int minutes, int seconds)
        {
            TStreamTime time = new TStreamTime();
            time.sec = (uint)ComputeSeconds(minutes, seconds);

            sound.Seek(TTimeFormat.tfSecond, ref time, TSeekMethod.smFromBeginning);
        }




        #endregion

        #region Private methods
        private int ComputeSeconds(int minutes, int seconds)
        {
            int newSeconds = seconds;
            newSeconds += (minutes * 60);

            return newSeconds;
        }

        #endregion
    }
}
