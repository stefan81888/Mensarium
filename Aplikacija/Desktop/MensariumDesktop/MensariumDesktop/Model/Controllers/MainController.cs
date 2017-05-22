﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;

namespace MensariumDesktop.Model.Controllers
{
    public static class MainController
    {
        public static void InitApplication()
        {
            //Ucitaj podatke iz fajl
            MSettings.Server = new Server();
        }

        public static bool LogUser(string username, string password)
        {
            ClientLoginDto clog = new ClientLoginDto{ KIme_Mail = username, Sifra = password };

            try
            {
                SesijaDto sesija = Api.LoginUser(clog);

                MSettings.CurrentSession = new Session() { SessionID = sesija.IdSesije };
                
                KorisnikFullDto korisnik = Api.GetUserFullInfo(sesija.IdKorisnika);
                MSettings.CurrentSession.LoggedUser = MUtility.User_From_KorisnikFullDto(korisnik);
                return true;
            }
            catch (Exception ex)
            {
                MSettings.CurrentSession = null;
                MessageBox.Show(ex.Message);
                return false;
            }
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