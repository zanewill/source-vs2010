using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ImageParser;

namespace Demo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SettingClass.Instance.ReadSetting();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AllInOne());
        }
    }
}
