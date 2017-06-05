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
            Menza m = s.Get<Menza>(id);
            return m;
        }

        public static List<Menza> VratiMenze()
        {
            ISession s = SesijeProvajder.Sesija;
            List<Menza> menze = s.Query<Menza>().Select(k => k).ToList();

            Menza m = menze.First(x => x.IdMenza == 4);
            menze.Remove(m);

            return menze.ToList();
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

        public static int BrojObrokaSkinutihUPoslednjihPetMinuta(int idMenze)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> obroci = s.Query<Obrok>().Select(k => k)
                .Where(k => k.LokacijaIskoriscenja.IdMenza == idMenze)
                .Where(k => k.Iskoriscen == true)
                .Where(k => k.DatumIskoriscenja <= DateTime.Now && k.DatumIskoriscenja >= DateTime.Now.AddMinutes(-5));
            return obroci.Count();
        }

        public static int BrojObrokaUplacenihUPoslednjihPetMinuta(int idMenze)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> obroci = s.Query<Obrok>().Select(k =>k)
                .Where(k => k.LokacijaUplate.IdMenza == idMenze)
                .Where(k => k.Iskoriscen == false)
                .Where(k => k.DatumUplacivanja <= DateTime.Now && k.DatumIskoriscenja >= DateTime.Now.AddMinutes(-5));
            return obroci.Count();
        }
    }
}