using libZPlay;

namespace QuandaryHint
{
    public class Audio
    {

        #region Variables
        //The variable that this wrapper is for
        private ZPlay sound;

        //A variable we can fetch for the config files
        public int volume;
        #endregion

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
            this.volume = volume / 10;
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
        public void FastForward(double minutes, double seconds)
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
        public void Rewind(double minutes, double seconds)
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

        /// <summary>
        /// Sets audio output
        /// </summary>
        /// <param name="i"></param>
        public void SetAudioOutput(uint i) => sound.SetWaveOutDevice(i);


        #endregion

        #region Private methods
        private double ComputeSeconds(double minutes, double seconds)
        {
            double newSeconds = seconds;
            newSeconds += (minutes * 60);

            return newSeconds;
        }

        #endregion
    }
}
