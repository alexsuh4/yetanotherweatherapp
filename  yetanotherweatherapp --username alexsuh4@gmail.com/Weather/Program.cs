﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Weather
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception exp)
            {
                MessageBox.Show("Dhoo!  sorry about that\n" + exp.Message);
            }
        }
    }
}
