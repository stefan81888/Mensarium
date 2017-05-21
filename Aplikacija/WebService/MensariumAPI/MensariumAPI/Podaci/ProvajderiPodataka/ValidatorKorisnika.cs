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

        public static bool PostojiUsername(string username)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> kor = ProvajderiPodataka.ProvajderPodatakaKorisnika.VratiKorisnike();

            List<Korisnik> korisnici = (from k in kor
                                        where k.KorisnickoIme == username
                                        select k).ToList();
            return korisnici.Count == 1;
        }

        

        public static bool PostojiEmail(string mail)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> kor = ProvajderiPodataka.ProvajderPodatakaKorisnika.VratiKorisnike();

            List<Korisnik> korisnici = (from k in kor
                                        where k.KorisnickoIme == mail
                                        select k).ToList();

            return korisnici.Count == 1;
        }
    }
}
