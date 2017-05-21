using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Components;

namespace MensariumDesktop.Model.Controllers
{
    public static class MainController
    {
        public static void InitApplication()
        {
            //Ucitaj podatke iz fajl
            MSettings.Server = new Server();
        }

        public static void LogUser()
        {
            
        }

        public static bool ChangeServerIP(string newIP)
        {
            return MSettings.Server.ChangeIP(newIP);
        }

        public static bool ChangeServerPort(string newPort)
        {
            return MSettings.Server.ChangePort(newPort);
        }

        public static bool ChangeServer(string newIP, string newPort)
        {
            return ChangeServerIP(newIP) && ChangeServerPort(newPort);
        }
    }
}
