using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public static class ValidatorKorisnika
    {
        public static bool KorisnikPostoji(Korisnik k)
        {
            return k != null;
        }

        public static Korisnik PostojiUsername(string username)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> kor = ProvajderiPodataka.ProvajderPodatakaKorisnika.VratiKorisnike();

            List<Korisnik> korisnici = (from k in kor
                                        where k.KorisnickoIme == username
                                        select k).ToList();
            s.Close();
            return korisnici[0];
        }

        public static LoginSesija ProveriSifru(Korisnik ko)
        {
            Korisnik korisnik = PostojiUsername(ko.KorisnickoIme) != null ?
                PostojiUsername(ko.KorisnickoIme) : PostojiEmail(ko.Email);

            if (korisnik != null && korisnik.Sifra == ko.Sifra)
            {
                ISession s = SesijeProvajder.Sesija;

                LoginSesija sesija = new LoginSesija()
                {
                    KorisnikSesije = korisnik,
                    IdSesije = Guid.NewGuid().ToString(),
                    DatumPrijavljivanja = DateTime.Now,
                    ValidnaDo = DateTime.Now.AddDays(2)
                };
                s.Save(sesija);
                s.Flush();
                s.Close();

                return sesija;
            }

            return null;

        }

        public static Korisnik PostojiEmail(string mail)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> kor = ProvajderiPodataka.ProvajderPodatakaKorisnika.VratiKorisnike();

            List<Korisnik> korisnici = (from k in kor
                where k.KorisnickoIme == mail
                select k).ToList();
            s.Close();
            return korisnici[0];
        }
    }
}