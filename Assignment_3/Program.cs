﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
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
            splash_screen splashScreen = new splash_screen();
            OrderForm orderForm = new OrderForm();
            MovieSelection movieSelection = new MovieSelection(splashScreen,orderForm);
            splashScreen.Show();
            Application.Run(movieSelection);
        }
    }
}
