using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    public class Server
    {
        public String serverIP { get; set; }
        public String serverPort { get; set; }

        public Server()
        {
            serverIP = "127.0.0.1";
            serverPort = "2244";
        }

        public Server(string serverIp, string serverPort)
        {
            serverIP = serverIp;
            this.serverPort = serverPort;
        }

        public string ServerURL
        {
            get
            {
                return string.Format("http://{0}:{1}/",
                    serverIP,
                    serverPort);
            }
        }
    }
}
