using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    public static class MSettings
    {
        public static Session CurrentSession { get; set; }
        public static Server Server { get; set; }

        static MSettings()
        {
            Server = new Server()
            {
                serverIP = "localhost",
                serverPort = "2244"
            };
        }

        public static void LoadSettings() { }
        public static void SaveSettings() { }
    }
}
