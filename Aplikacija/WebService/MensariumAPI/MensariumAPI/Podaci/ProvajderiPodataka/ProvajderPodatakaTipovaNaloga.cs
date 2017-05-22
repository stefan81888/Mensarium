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
    public class ProvajderPodatakaTipovaNaloga
    {
        public static TipNaloga VratiTipNaloga(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            TipNaloga t = s.Load<TipNaloga>(id);
            return t;
        }

        public static IEnumerable<TipNaloga> VratiTipoveNaloga()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<TipNaloga> tipoviNaloga = s.Query<TipNaloga>().Select(k => k);
            return tipoviNaloga;
        }

        public static TipNaloga VratiTipNalogaKorisnika(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik kor = s.Load<Korisnik>(id);
            return kor.TipNaloga;
        }

        public static List<Privilegija> VratiPrivilegijeKorisnika(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Korisnik kor = s.Load<Korisnik>(id);
            return kor.TipNaloga.Privilegije.ToList<Privilegija>();
        }
    }
}