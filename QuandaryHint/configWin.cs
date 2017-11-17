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
        public configWin(hintWindow hintWin, Form1 form1)
        {
            InitializeComponent();
            _hintWin = hintWin;
            _form1 = form1;

            //Initialize fontAdjuster
            fontAdjuster.Value = (decimal)_hintWin.hintLabel.Font.Size;
            checkBox1.Checked = _form1.captureOnlyInForeground;



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

                    _form1.zplayer.SetWaveOutDevice((uint)i);
                    _form1.videoSound.SetWaveOutDevice((uint)i);
                }

            }
        }

        private void audioSetterBox_Click(object sender, EventArgs e)
        {
            audioSetterBox.Items.Clear();
            TWaveOutInfo WaveOutInfo = new TWaveOutInfo();
            int WaveOutNum = _form1.zplayer.EnumerateWaveOut();
            uint i;
            for (i = 0; i < WaveOutNum; i++)
            {
                if (_form1.zplayer.GetWaveOutInfo(i, ref WaveOutInfo))
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
            _form1.videoSound.SetPlayerVolume(volume, volume);
            _form1.zplayer.SetPlayerVolume(volume, volume);
            
        }
    }
}