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
    public class ProvajderPodatakaPrivilegija
    {
        public static Privilegija VratiPrivilegiju(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Privilegija p = s.Load<Privilegija>(id);
            return p;
        }

        public static IEnumerable<Privilegija> VratiSvePrivilegije()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Privilegija> privilegije = s.Query<Privilegija>().Select(k => k);
            return privilegije;
        }
        
    }
}