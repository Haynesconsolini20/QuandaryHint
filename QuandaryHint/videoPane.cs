using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using Microsoft.DirectX;
using System.IO;

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

        
    }
}
