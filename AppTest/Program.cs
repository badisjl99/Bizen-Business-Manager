using AppTest.AppLogin;
using AppTest.Controllers;
using AppTest.Models;
using System;
using System.Windows.Forms;

namespace AppTest
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new SignUpForm());
            Application.Run(new LoginForm());
            // Application.Run(new TestForm());

        }
    }
}
