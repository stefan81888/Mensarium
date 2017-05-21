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
    public class ProvajderPodatakaMenzi
    {
        public static Menza VratiMenzu(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Menza m = s.Load<Menza>(id);
            return m;
        }

        public static IEnumerable<Menza> VratiMenze()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Menza> menze = s.Query<Menza>().Select(k => k);
            return menze;
        }

        public static void DodajMenzu(Menza m)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(m);
            s.Flush();
        }

        public static void UpdateMenzu(Menza m)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Update(m);
            s.Flush();
        }

        public static void ObrisiMenzu(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Menza m = s.Load<Menza>(id);
            s.Delete(m);
            s.Flush();
        }
    }
}