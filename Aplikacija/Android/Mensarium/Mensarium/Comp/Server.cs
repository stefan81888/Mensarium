using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mensarium.Components
{
    public class Server
    {
        public string IP { get; protected set; }
        public string Port { get; protected set; }

        public Server()
        {
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

        public bool ChangeIP(string newIP)
        {
            //TO-DO napravi i da moze hostname da se unese
            //IPAddress newAddress;
            //bool isValid = IPAddress.TryParse(newIP, out newAddress);

            //if (isValid)
            //{
            //   IP = newAddress.ToString();
            //   return true;
            //}

            //MessageBox.Show("Nevalidna IP adresa");
            //return false;
            IP = newIP;
            return true;
        }

        public bool ChangePort(string newPort)
        {
            int port;
            bool isValid = int.TryParse(newPort, out port);
            if (isValid && port >= 0 && port <= 65535)
            {
                Port = newPort;
                return true;
            }
            //MessageBox.Show("Nevalidna vrednost porta");
            return false;
        }
    }
}