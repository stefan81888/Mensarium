using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodataka
    {
        public static Korisnik VratiKorisnika(int id)
        {
            SesijeProvajder.OtvoriSesiju();
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = s.Load<Korisnik>(id);
            SesijeProvajder.ZatvoriSesiju();
            return k;
        }

        //public static List<Korisnik> VratiKorisnike()
        //{
        //    ISession s = SesijeProvajder.Sesija;
        //    List<Korisnik> korisnici = s.
        //}

        public static void DodajKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(k);
            s.Flush();
            s.Close();
        }
    }
}