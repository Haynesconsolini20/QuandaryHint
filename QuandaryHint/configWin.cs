using System;
using System.Drawing;
using System.Windows.Forms;
using libZPlay;

namespace QuandaryHint
{
    public partial class configWin : Form
    {
        private hintWindow _hintWin;
        private Form1 _form1;
        private Game testGame;
        public configWin(hintWindow hintWin, Form1 form1, Game testGame)
        {
            InitializeComponent();
            _hintWin = hintWin;
            _form1 = form1;
            this.testGame = testGame;

            //Initialize fontAdjuster
            fontAdjuster.Value = (decimal)_hintWin.hintLabel.Font.Size;
            checkBox1.Checked = true;

           // volumeSlider.Value = _form1.hintVolume;
           // numericUpDown2.Value = _form1.gameVolume;



        }

        private void fontAdjuster_ValueChanged(object sender, EventArgs e)
        {
            string fontName = _hintWin.hintLabel.Font.Name;
            float fontSize = (float)fontAdjuster.Value;
            System.Drawing.Font newFont = new Font(fontName, fontSize);
            _hintWin.hintLabel.Font = newFont;
        }

        private void psychButton_Click(object sender, EventArgs e)
        {
           
            if (_hintWin.hintLabel.BackColor == System.Drawing.SystemColors.WindowText)
            {
                _hintWin.hintLabel.BackColor = System.Drawing.Color.DarkSlateGray;

            }
            else
            {
                _hintWin.hintLabel.BackColor = System.Drawing.SystemColors.WindowText;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            this.Hide();
            e.Cancel = true;
        }

        private void audioSetterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < audioSetterBox.Items.Count; i++)
            {
                if (audioSetterBox.Items[i] == audioSetterBox.Items[audioSetterBox.SelectedIndex])
                {

                  //  _form1.zplayer.SetWaveOutDevice((uint)i);
                  //  _form1.videoSound.SetWaveOutDevice((uint)i);
                }

            }
        }

        private void audioSetterBox_Click(object sender, EventArgs e)
        {
            audioSetterBox.Items.Clear();
            TWaveOutInfo WaveOutInfo = new TWaveOutInfo();
           // int WaveOutNum = _form1.zplayer.EnumerateWaveOut();
            uint i;
           // for (i = 0; i < WaveOutNum; i++)
            {
               // if (_form1.zplayer.GetWaveOutInfo(i, ref WaveOutInfo))
                {
                    audioSetterBox.Items.Add(WaveOutInfo.ProductName);
                }
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                _form1.captureOnlyInForeground = true;
            else
                _form1.captureOnlyInForeground = false;
        }

        private void volumeSlider_ValueChanged(object sender, EventArgs e)
        {
            int volume = volumeSlider.Value;
            testGame.hintSound.SetVolume(volume);
           // testGame.SetGameVolume(volumeSlider.Value);
           // volume *= 10;
         //   _form1.zplayer.SetPlayerVolume(volume, volume);
           // _form1.testGame.SetGameVolume(volumeSlider.Value);
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            double offset = ((double)numericUpDown1.Value * 0.1);
           // _form1.VIDEO_OFFSET = offset;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // _form1.playbackPosition = _form1.video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
           // _form1.video.axWindowsMediaPlayer1.Ctlcontrols.stop();
          //  _form1.previewVideo.axWindowsMediaPlayer1.Ctlcontrols.stop();

           // _form1.videoSound.PausePlayback();
            

            decimal rewindInSeconds = secAdjust.Value + (minAdjust.Value * 60);
            TStreamTime time = new TStreamTime();
            time.sec = (uint)rewindInSeconds;

           // _form1.videoSound.Seek(TTimeFormat.tfSecond, ref time, TSeekMethod.smFromCurrentBackward);

           // _form1.video.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (_form1.playbackPosition - (double)rewindInSeconds);
           // _form1.previewVideo.axWindowsMediaPlayer1.Ctlcontrols.currentPosition = (_form1.playbackPosition - (double)rewindInSeconds);

           // _form1.videoSound.ResumePlayback();
          //  _form1.video.axWindowsMediaPlayer1.Ctlcontrols.play();
           // _form1.previewVideo.axWindowsMediaPlayer1.Ctlcontrols.play();

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int volume = volumeSlider.Value;
            volume *= 10;

          //  _form1.videoSound.SetMasterVolume(0, 0);
          //  
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            int volume = (int)numericUpDown2.Value;
            testGame.videoSound.SetVolume(volume);
            
            volume *= 10;

           // _form1.videoSound.SetPlayerVolume(volume, volume);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
                _form1.captureOnlyInForeground = false;
            else
                _form1.captureOnlyInForeground = true;
        }
    }
}