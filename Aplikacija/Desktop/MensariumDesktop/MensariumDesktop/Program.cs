using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Forms;
using MensariumDesktop.Model.Controllers;


using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using System.Threading;
using System.ComponentModel;

namespace MensariumDesktop
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

            MainController.InitApplication();
            LoginForm fLogin = new LoginForm();
            
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());                   
            }

            Application.Exit();

            //Application.Run(new MainForm());
            //Application.Run(new LoginForm());
        }
    }
}
