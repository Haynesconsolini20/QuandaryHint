using System.Drawing;
using System.Windows.Forms;

namespace QuandaryHint
{
    public class Hint
    {
        //The window we're wrapping
        hintWindow hint;

        //Is it the preview window?
        bool preview;

        /// <summary>
        /// NDC taking a bool
        /// for if it's a preview window or the game window
        /// </summary>
        /// <param name="name"></param>
        public Hint(bool preview)
        {
            hint = new hintWindow();
            this.preview = preview;
            SetDoubleBuffered(hint);
          
        }

        //TODO LIST

        /// <summary>
        /// Gets the game options and sets up the label stylistically
        /// </summary>
        /// <param name="gameO"></param>
        public void CopyGameOptions(GameOptions gameO)
        {
            if (preview)
                hint.hintLabel.Font = gameO.previewFont;
            else
                hint.hintLabel.Font = gameO.hintFont;

            hint.hintLabel.ForeColor = gameO.fontColor;
            hint.Text = gameO.gameMode + " Hints";

            if (gameO.gameMode == "The Psych Ward")
            {
                hint.hintLabel.TextAlign = ContentAlignment.TopCenter;
               
                hint.hintLabel.Padding = new Padding(0, 50, 0, 0);
            }

        }

        //Passable to config win --Low priority

        /// <summary>
        /// Used to keep the window from flickering so much during use
        /// </summary>
        /// <param name="c"></param>
        private static void SetDoubleBuffered(System.Windows.Forms.Control c)
        {
            if (System.Windows.Forms.SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo aProp =
                  typeof(System.Windows.Forms.Control).GetProperty(
                        "DoubleBuffered",
                        System.Reflection.BindingFlags.NonPublic |
                        System.Reflection.BindingFlags.Instance);

            aProp.SetValue(c, true, null);
        }

       /// <summary>
       /// Set the label to a string
       /// </summary>
       /// <param name="hintText"></param>
        public void SetHint(string hintText)
        {
            hint.hintLabel.Text = hintText;
        }

        /// <summary>
        /// Toggles the border on and off
        /// </summary>
        public void ToggleBorder()
        {
            if (hint.FormBorderStyle == FormBorderStyle.Sizable)
            {
                hint.FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                hint.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        /// <summary>
        /// Location getter
        /// </summary>
        /// <returns></returns>
        public Point GetLocation()
        {
            return hint.Location;
        }

        /// <summary>
        /// Location setter
        /// </summary>
        /// <param name="pt"></param>
        public void SetLocation(Point pt)
        {
            hint.Location = pt;
        }

        /// <summary>
        /// Size setter
        /// </summary>
        /// <param name="sz"></param>
        public void SetSize(Size sz)
        {
            hint.Size = sz;
        }

        /// <summary>
        /// Shows the window
        /// </summary>
        public void ShowWindow() => hint.Show();



    }
}
