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
    public class ProvajderPodatakaSesije
    {
        public static LoginSesija VratiSesiju(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            LoginSesija sesija = s.Load<LoginSesija>(id);
            return sesija;
        }

        public static List<LoginSesija> VratiSesije()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<LoginSesija> sesije = s.Query<LoginSesija>().Select(k => k);
            return sesije.ToList();
        }

        public static int NadjiIdVlasnikaSesije(string idSesije)
        {
            ISession s = SesijeProvajder.Sesija;
            return s.Query<LoginSesija>().Select(k => k.KorisnikSesije.IdKorisnika).ToList()[0];
        }

        public static TipNaloga TipNalogaVlasnikaSesije(string idSesije)
        {
            ISession s = SesijeProvajder.Sesija;
            return s.Query<LoginSesija>().Select(k => k.KorisnikSesije.TipNaloga).ToList()[0];
        }
    }
}