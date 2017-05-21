using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Components;

namespace MensariumDesktop.Model
{
    public static class MensariumConfig
    {
        public static string ServerIP { get; set; }
        public static string ServerPort { get; set; }
        public static User LoggedUser { get; set; }

        static MensariumConfig()
        {
            ServerIP = "localhost";
            ServerPort = "2244";
        }

        public static string ServerURL
        {
            get
            {
                return string.Format("http://{0}:{1}/",
                    ServerIP,
                    ServerPort);
            }
        }

        public static void LoadSettings()
        {
            
        }

        public static void SaveSettings()
        {
            
        }
    }
}
