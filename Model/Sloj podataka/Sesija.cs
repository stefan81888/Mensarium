using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensarium_Desktop.Mapiranja;
using MySql;
using MySql.Data.MySqlClient;
using FluentNHibernate.Cfg.Db;

namespace Mensarium_Desktop.Sloj_podataka
{
    class Sesija
    {
        private static ISessionFactory instanca = null;
        private static object zakljucaj = new object();
        private static string konekcioniString = @"Data Source=160.99.38.10; Database=mensarium_db; User ID=mensarium; Password='Vodja.204'; Port=6666;";

        public static string KonekcioniString
        {
            get { return konekcioniString; }
            private set { konekcioniString = value; } // Konekcioni string se konfigurise samo u ovoj klasi
        }

        //Funkcija na zahtev otvara sesiju
        public static ISession VratiSesiju()
        {
            //Ukoliko instanca nije kreirana
            if (instanca == null)
            {
                lock (zakljucaj)
                {
                    if (instanca == null)
                        instanca = NapraviSesiju();
                }
            }

            return instanca.OpenSession();
        }

        //Konfiguracija i kreiranje instance
        private static ISessionFactory NapraviSesiju()
        {
            try
            {
                return Fluently.Configure().Database(
                        MySQLConfiguration.Standard.ConnectionString(
                            c => c.FromConnectionStringWithKey(konekcioniString)
                        )
                    )
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<KorisnikMapiranje>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                // Obraditi izuzetak
                return null;
            }

        }
    }
}
