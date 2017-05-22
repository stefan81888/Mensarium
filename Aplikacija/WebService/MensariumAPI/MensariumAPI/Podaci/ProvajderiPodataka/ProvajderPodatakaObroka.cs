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

        public static List<Obrok> VratiObroke()
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> obroci = s.Query<Obrok>().Select(k => k);
            return obroci.ToList();
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
            List<Obrok> ovomesecniObrociOvogKorisnika = s.Query<Obrok>().Select(k => k)
                .Where(k => k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.Tip.IdTipObroka == idTipaObroka)
                .Where(k => k.DatumUplacivanja.Month == DateTime.Now.Month)
                .ToList();

            int br = ovomesecniObrociOvogKorisnika.Count();
            return br == 30;
        }

        public static Obrok ObrokZaSkidanjeOvogTipa(int idKorisnika, int idTipaObroka)
        {
            //prvi obrok koji je neiskoriscen, a uplacen ovog meseca
            ISession s = SesijeProvajder.Sesija;
            List<Obrok> listaNeiskoriscenihObroka = s.Query<Obrok>().Select(k => k)
                .Where(k => k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.DatumUplacivanja.Month == DateTime.Now.Month)
                .Where(k => k.Tip.IdTipObroka == idTipaObroka)
                .Where(k => k.Iskoriscen == false).ToList();

            if (listaNeiskoriscenihObroka != null)
                return listaNeiskoriscenihObroka[0];
            return null;
        }

        public static List<Obrok> DanasUplaceniNeiskorisceniObrociKorisnika(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            IEnumerable<Obrok> danasUplaceni = s.Query<Obrok>().Select(k => k).Where(k => k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.DatumUplacivanja.Day == DateTime.Now.Day)
                .Where(k => k.Iskoriscen == false)
                .Where(k => k.DatumIskoriscenja == null)
                .Where(k => k.LokacijaIskoriscenja == null);
            return danasUplaceni.ToList();
        }

        public static List<Obrok> DanasSkinutiObrociKorisnika(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            DateTime danasPonoc = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 1);
            IEnumerable<Obrok> danasSkinuti = s.Query<Obrok>().Select(k => k)
                .Where(k => k.Iskoriscen == true && k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.DatumIskoriscenja <= DateTime.Now && k.DatumIskoriscenja >= danasPonoc);
            return danasSkinuti.ToList();
        }
    }
}