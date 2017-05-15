using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.Konfigracija
{
    public static class Konfiguracija
    {
        public static string ServerIP { get; set; }
        public static string ServerPort { get; set; }
        public static string DBKorisnickoIme { get; set; }
        public static string DBLozinka { get; set; }
        public static string DBSema { get; set; }

        public static TimeSpan VremeVazenjaKartice { get; set; }
        
            
        static Konfiguracija()
        {
            ServerIP = "160.99.38.10";
            ServerPort = "6666";
            DBKorisnickoIme = "mensarium";
            DBLozinka = "Vodja.204";
            DBSema = "mensarium_db";

            VremeVazenjaKartice = new TimeSpan(365,0,0,0);
        }

        public static string KonekcioniString
        {
            get
            {
                return string.Format("Server={0};User Id={1};Password={2};Database={3};Port={4};",
                                          ServerIP,
                                          DBKorisnickoIme,
                                          DBLozinka,
                                          DBSema,
                                          ServerPort);
            }
        }

        
        //Nije mu mesto ovde al neka ga za sad ovde
        //Stampa izuzetak sa svim unutrasnjim izuzecima (InnerException)
        public static void StampajIzuzetak(Exception error)
        {
            Console.WriteLine("=== IZUZETAK ===");
            Exception ex = error;
            while (ex.InnerException != null)
            {
                Console.WriteLine(ex.Message);
                ex = ex.InnerException;
            }
            //Exception realerror = error;
            //while (realerror.InnerException != null)
            //    realerror = realerror.InnerException;
            Console.WriteLine("================");


        }
    }
}