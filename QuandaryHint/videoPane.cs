using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuandaryHint
{
    public partial class videoPane : Form
    {

       

        public videoPane()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Location = new Point(0, 0);
            axWindowsMediaPlayer1.settings.mute = true;
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.Size = new Size(this.Width, this.Height);
            
            
        }

       




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1 && axWindowsMediaPlayer1.URL == @"C:\DI_Victory.wmv")
            {
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration - 1.001;
                axWindowsMediaPlayer1.Ctlcontrols.play();
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void axWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            if (axWindowsMediaPlayer1.Ctlcontrols.currentPosition == axWindowsMediaPlayer1.currentMedia.duration - 1.00)
                axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    }
}
