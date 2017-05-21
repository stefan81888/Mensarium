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

        public static void PojediObrok(int id, int idLokacijeIskoriscenja)
        {
            ISession s = SesijeProvajder.Sesija;
            Obrok o = s.Load<Obrok>(id);
            o.Iskoriscen = true;
            o.DatumIskoriscenja = DateTime.Now;
            o.LokacijaIskoriscenja = s.Load<Menza>(idLokacijeIskoriscenja);
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

        public static IEnumerable<Obrok> DanasUplaceniNeiskorisceniObrociKorisnika(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> danasUplaceni = s.Query<Obrok>().Select(k => k).Where(k => k.Uplatilac.IdKorisnika == idKorisnika && k.DatumUplacivanja.Day == DateTime.Now.Day && k.Iskoriscen == false);
            return danasUplaceni;
        }

        public static IEnumerable<Obrok> DanasSkinutiObrociKorisnika(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            DateTime danasPonoc = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 1);
            IEnumerable<Obrok> danasSkinuti = s.Query<Obrok>().Select(k => k)
                .Where(k => k.Iskoriscen == true && k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.DatumIskoriscenja <= DateTime.Now && k.DatumIskoriscenja >= danasPonoc);
            return danasSkinuti;
        }
    }
}