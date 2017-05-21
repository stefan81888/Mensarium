using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;
using NHibernate.Linq;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodataka
    {
        public static Korisnik VratiKorisnika(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik k = s.Load<Korisnik>(id);
            return k;
        }

        public static IEnumerable<Korisnik> VratiKorisnike()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> korisnici = s.Query<Korisnik>().Select(k => k);
            return korisnici;
        }

        public static void DodajKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(k);
            s.Flush();
            s.Close();
        }

        public static void UpdateKorisnika(Korisnik k)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Update(k);
            s.Flush();
            s.Close();
        }

        public static SesijaDto PrijavaKorisnika(Korisnik k)
        {
            LoginSesija sesija = Validator.ProveriSifru(k);
            return new SesijaDto()
            {
                IdSesije = sesija.IdSesije,
                IdKorisnika = sesija.KorisnikSesije.IdKorisnika,
                DatumPrijavljivanja = sesija.DatumPrijavljivanja,
                ValidnaDo = sesija.ValidnaDo
            };
        }
    }
}