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
    public class ProvajderPodatakaObroka
    {
        public static Obrok VratiObrok(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Obrok o = s.Load<Obrok>(id);
            return o;
        }

        public static IEnumerable<Obrok> VratiObroke()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> obroci = s.Query<Obrok>().Select(k => k);
            return obroci;
        }

        public static void DodajObrok(Obrok o)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Save(o);
            s.Flush();
        }

        public static void UpdateObrok(Obrok o)
        {
            ISession s = SesijeProvajder.Sesija;
            s.Update(o);
            s.Flush();
        }

        public static void ObrisiObrok(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Obrok o = s.Load<Obrok>(id);
            s.Delete(o);
            s.Flush();
        }

        public static bool KorisnikDostigaoLimitZaOvajMesecZaOvajObrok(int idKorisnika, int idTipaObroka)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> obrociOvogKorisnika = s.Query<Obrok>().Select(k => k).Where(k => k.Uplatilac.IdKorisnika == idKorisnika && k.Tip.IdTipObroka == idTipaObroka);
            List<Obrok> listaObrokaOvogKorisnika = obrociOvogKorisnika.ToList();
            int br = (from o in listaObrokaOvogKorisnika
                      where o.DatumUplacivanja.Month == DateTime.Now.Month
                      select o).Count();
            return br == 30;
        }

        public static Obrok ObrokZaSkidanjeOvogTipa(int idKorisnika, int idTipaObroka)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> neiskorisceniObroci = s.Query<Obrok>().Select(k => k).Where(k => k.Uplatilac.IdKorisnika == idKorisnika && k.Tip.IdTipObroka == idTipaObroka && k.Iskoriscen == false);
            List<Obrok> listaNeiskoriscenihObroka = neiskorisceniObroci.ToList();
            if (neiskorisceniObroci == null)
                return null;
            else
                return listaNeiskoriscenihObroka[0];
        }
    }
}