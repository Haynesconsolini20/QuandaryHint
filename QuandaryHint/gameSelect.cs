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
        public System.Drawing.Color fontColor;
        public string videoPath;
        public string audioPath;
        public double timerOffset;
        
        

    }

    public partial class gameSelect : Form
    {
        

        public GameOptions gameOptions;

        public gameSelect()
        {
            InitializeComponent();
        }

        private void lockedInDead_Click(object sender, EventArgs e)
        {
            gameOptions.welcomeMessage = "Welcome to the Locked in Dead...";
            gameOptions.hintFont = new Font("Chiller", 22);
            gameOptions.previewFont = new Font("Chiller", 12);
            gameOptions.fontColor = Color.White;
            gameOptions.gameMode = "The Locked In Dead";
            gameOptions.audioPath = "deadSound.mp3";
            gameOptions.videoPath = @"C:\LID.wmv";
            gameOptions.timerOffset = 108;
            this.Close();
        }

        private void runawayTrain_Click(object sender, EventArgs e)
        {
            gameOptions.welcomeMessage = "Welcome to the Runaway Train...";
            gameOptions.hintFont = new Font("Lucida Console", 22);
            gameOptions.previewFont = new Font("Lucida Console", 12);
            gameOptions.fontColor = Color.Green;
            gameOptions.gameMode = "The Runaway Train";
            gameOptions.audioPath = "trainSound.mp3";
            gameOptions.videoPath = @"C:\RT.wmv";
            gameOptions.timerOffset = 140;
            this.Close();
        }

        private void psychWard_Click(object sender, EventArgs e)
        {
            gameOptions.gameMode = "The Psych Ward";
            gameOptions.welcomeMessage = "Welcome to the Dynaline Incident";
            gameOptions.hintFont = new Font("Ailerons", 22);
            gameOptions.previewFont = new Font("Ailerons", 12);
            gameOptions.fontColor = Color.White;
            gameOptions.audioPath = "dynalineSound.mp3";
            gameOptions.videoPath = @"C:\DI.wmv";
            gameOptions.timerOffset = 95;
            this.Close();
        }
    }
}
