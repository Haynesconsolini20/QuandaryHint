using System;
using System.Windows.Forms;

namespace QuandaryHint
{
    public partial class hintWindow : Form
    {
        
        public hintWindow()
        {
            InitializeComponent();
            //hintLabel.Size = new System.Drawing.Size(this.Width, this.Height);
           
        }

        

        private void hintLabel_Click(object sender, EventArgs e)
        {

        }

        private void hintWindow_Load(object sender, EventArgs e)
        {

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            this.Hide();
            e.Cancel = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void hintLabel_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
