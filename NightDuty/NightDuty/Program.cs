using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NightDuty
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Get full folder path where database file exists using the relative path if required
            string dbpath = System.IO.Path.GetFullPath(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"MyDatabase"));
            //Register this path in DataDirectory
            AppDomain.CurrentDomain.SetData("DataDirectory", dbpath);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}