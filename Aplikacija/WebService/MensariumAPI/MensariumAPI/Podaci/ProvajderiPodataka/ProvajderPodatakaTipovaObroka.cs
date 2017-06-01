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
    public class ProvajderPodatakaTipovaObroka
    {
        public static TipObroka VratiTipObroka(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            TipObroka t = s.Get<TipObroka>(id);
            return t;
        }

        public static IEnumerable<TipObroka> VratiTipoveObroka()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<TipObroka> tipoviObroka = s.Query<TipObroka>().Select(k => k);
            return tipoviObroka;
        }
    }
}