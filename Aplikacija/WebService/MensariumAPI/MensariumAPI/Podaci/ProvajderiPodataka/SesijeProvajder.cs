using FluentNHibernate.Cfg;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using FluentNHibernate.Cfg.Db;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.Mapiranja; 
using MensariumAPI.Podaci.Konfigracija;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public static class SesijeProvajder
    {
        private static ISessionFactory instanca = null;
        private static object zakljucaj = new object();
        
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
                var cfg = MySQLConfiguration.Standard.ConnectionString(
                        c => c.Is(Konfiguracija.KonekcioniString));

                return Fluently.Configure()
                            .Database(cfg.ShowSql)
                            .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                            //.ExposeConfiguration(BuildSchema)
                            .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                Konfiguracija.StampajIzuzetak(ec);
                return null;
            }

        }
    }
}
