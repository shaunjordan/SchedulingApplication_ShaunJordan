using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Globalization;


namespace SchedulingUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentCulture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main());

            // TODO: add this back after debugging. 
            Main mainScreen = new Main();
            LoginForm loginForm = new LoginForm(ci);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(mainScreen);
            }


        }

    }
}
