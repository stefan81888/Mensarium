using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci
{
    public static class DnevnikIzuzetaka
    {
        private static string appDataFolder = HttpContext.Current.Server.MapPath("~/App_Data/");
        private static string filename = "exception_log.txt";
        private static string LogPath { get { return appDataFolder + filename; } }
        
        public static void Zabelezi(Exception e)
        {
            string Text = string.Format("[{0}]\t{1}\n", DateTime.Now, e.Message);
            System.IO.File.AppendAllText(LogPath, Text);
        }
    }
}