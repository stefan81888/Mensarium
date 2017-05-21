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
    public class ProvajderPodatakaFakulteta
    {
        public static Fakultet VratiFakultet(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Fakultet f = s.Load<Fakultet>(id);
            return f;
        }

        public static IEnumerable<Fakultet> VratiFakultete()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Fakultet> fakulteti = s.Query<Fakultet>().Select(k => k);
            return fakulteti;
        }

        public static void DodajFakultet(Fakultet f)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(f);
            s.Flush();
            s.Close();
        }
    }
}