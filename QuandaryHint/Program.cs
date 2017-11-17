﻿using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QuandaryHint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gameSelect gamePicker = new gameSelect();
            Application.Run(gamePicker);
            Application.Run(new Form1(new hintWindow(), gamePicker));     
        }
    }
}
