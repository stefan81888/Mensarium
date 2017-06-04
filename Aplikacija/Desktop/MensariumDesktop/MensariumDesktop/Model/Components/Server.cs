using MensariumDesktop.Model.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MensariumDesktop.Model.Components
{
    public class Server
    {
        private string _ip;
        private string _port;
       
        public string IP
        {
            get{ return _ip; }
            set
            {
                if (Regex.IsMatch(value, @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$")
                    || Regex.IsMatch(value, @"^(([a-zA-Z]|[a-zA-Z][a-zA-Z0-9\-]*[a-zA-Z0-9])\.)*([A-Za-z]|[A-Za-z][A-Za-z0-9\-]*[A-Za-z0-9])$"))
                    _ip = value;
                else
                    throw new ArgumentException("Nevalidna adresa hosta");
            }
        }
        public string Port
        {
            get { return _port; }
            set
            {
                int port;
                int.TryParse(value, out port);
                if (port > 0 && port < 65535)
                    _port = value;
                else
                    throw new ArgumentException("Nevalidna adresa hosta");
            }
        }

        public Server()
        {
            //IP = "localhost";
            IP = "localhost";
            Port = "2244";
        }

        public Server(string ip, string port)
        {
            IP = ip;
            this.Port = port;
        }

        public string ServerURL => string.Format("http://{0}:{1}/",
            IP,
            Port);

    }
}
