using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public static class Validator
    {
        public static bool KorisnikPostoji(Korisnik k)
        {
            return k != null;
        }

        public static bool PostojiUsername(string username)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Korisnik> kor = ProvajderiPodataka.ProvajderPodataka.VratiKorisnike();

            int br = (from k in kor
                                        where k.Sifra == username
                                        select k).ToList().Count;
            s.Close();
            return br == 1;
        }
    }
}