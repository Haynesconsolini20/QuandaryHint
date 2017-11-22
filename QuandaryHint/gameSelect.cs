using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuandaryHint
{
    public struct GameOptions
    {
        public string welcomeMessage;
        public string gameMode;
        public Font hintFont;
        public Font previewFont;
        public Color fontColor;
        public string videoPath;
        public string audioPath;
        public double timerOffset;
        public double videoOffset;
        public int gameVolume;
        public int hintVolume;
        public int gameColumn;
        public int hintFontSize;
        public int waveOut;
        
        

    }

    public partial class gameSelect : Form
    {
        
        //.8 video offset for dynaline
        //1 for dead
        //?? for train
        public GameOptions gameOptions;

        public gameSelect()
        {
            InitializeComponent();
            gameOptions.waveOut = 10;
        }

        private void lockedInDead_Click(object sender, EventArgs e)
        {
            gameOptions.welcomeMessage = "Welcome to the Locked in Dead...";
            gameOptions.hintFontSize = 51;
            gameOptions.hintFont = new Font("Chiller", gameOptions.hintFontSize);
            gameOptions.previewFont = new Font("Chiller", 12);
            gameOptions.fontColor = Color.White;
            gameOptions.gameMode = "The Locked In Dead";
            gameOptions.audioPath = @"assets\deadSound.mp3";
            gameOptions.videoPath = @"C:\LID.wmv";
            gameOptions.timerOffset = 108;
            gameOptions.videoOffset = 0;
            gameOptions.hintVolume = 5;
            gameOptions.gameVolume = 9;
            gameOptions.gameColumn = 1;
            this.Close();
        }

        private void runawayTrain_Click(object sender, EventArgs e)
        {
            gameOptions.welcomeMessage = "Welcome to the Runaway Train...";
            gameOptions.hintFontSize = 22;
            gameOptions.hintFont = new Font("Lucida Console", gameOptions.hintFontSize);
            gameOptions.previewFont = new Font("Lucida Console", 12);
            gameOptions.fontColor = Color.Green;
            gameOptions.gameMode = "The Runaway Train";
            gameOptions.audioPath = @"assets\trainSound.mp3";
            gameOptions.videoPath = @"C:\RT.wmv";
            gameOptions.timerOffset = 140;
            gameOptions.videoOffset = 3740;
            gameOptions.hintVolume = 10;
            gameOptions.gameVolume = 10;
            gameOptions.gameColumn = 7;
            this.Close();
        }

        private void psychWard_Click(object sender, EventArgs e)
        {
            gameOptions.gameMode = "The Psych Ward";
            gameOptions.welcomeMessage = "Welcome to the Dynaline Incident";
            gameOptions.hintFontSize = 22;
            gameOptions.hintFont = new Font("Ailerons", gameOptions.hintFontSize);
            gameOptions.previewFont = new Font("Ailerons", 12);
            gameOptions.fontColor = Color.White;
            gameOptions.audioPath = @"assets\dynalineSound.mp3";
            gameOptions.videoPath = @"C:\DI.wmv";
            gameOptions.timerOffset = 95;
            gameOptions.videoOffset = 95;
            gameOptions.hintVolume = 1;
            gameOptions.gameVolume = 5;
            gameOptions.gameColumn = 13;
            this.Close();
        }
    }
}
