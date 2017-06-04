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

        public static Dictionary<string, int> SmsUplate = new Dictionary<string, int>()
        {
            {"Dorucak", 1},
            {"dorucak", 1},
            {"Doručak", 1},
            {"doručak", 2},
            {"Rucak", 2},
            {"Ručak", 2},
            {"rucak", 2},
            {"ručak", 2},
            {"Vecera", 3},
            {"Večera", 3},
            {"vecera", 3},
            {"večera", 3}
        };

        public static bool UplatiObrok(int id, int brojObroka, int tipObroka)
        {
            if (brojObroka == 0)
                return false;

            Korisnik k = ProvajderPodatakaKorisnika.VratiKorisnika(id);

            if (k == null)
                return false;

            if (k.TipNaloga.IdTip != 5)
                return false;

            for (int i = 0; i < brojObroka; i++)
            {
                Obrok o = new Obrok()
                {
                    Iskoriscen = false,
                    DatumUplacivanja = DateTime.Now,
                    DatumIskoriscenja = null,
                    Uplatilac = k,
                    Tip = ProvajderPodatakaTipovaObroka.VratiTipObroka(tipObroka),
                    LokacijaIskoriscenja = null
                };

                k.Obroci.Add(o);

            }
            return true;
        }

        public static Obrok VratiObrok(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Obrok o = s.Get<Obrok>(id);
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
            Obrok o = s.Get<Obrok>(id);
            o.Iskoriscen = true;
            o.DatumIskoriscenja = DateTime.Now;
            o.LokacijaIskoriscenja = s.Load<Menza>(idLokacijeIskoriscenja);
            s.Update(o);
            s.Flush();
        }

        public static void ObrisiObrok(int id)
        {
            ISession s = SesijeProvajder.Sesija;
            Obrok o = s.Get<Obrok>(id);
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

            if (listaNeiskoriscenihObroka.Count > 0)
                return listaNeiskoriscenihObroka[0];
            return null;
        }

        public static List<Obrok> DanasUplaceniNeiskorisceniObrociKorisnika(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            List<Obrok> danasUplaceni = s.Query<Obrok>().Select(k => k).Where(k => k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.DatumUplacivanja.Day == DateTime.Now.Day)
                .Where(k => k.Iskoriscen == false)
                .Where(k => k.DatumIskoriscenja == null)
                .Where(k => k.LokacijaIskoriscenja == null).ToList();
            if (danasUplaceni.Count > 0)
                return danasUplaceni.ToList();
            return null;
        }

        public static List<Obrok> DanasSkinutiObrociKorisnika(int idKorisnika)
        {
            ISession s = SesijeProvajder.Sesija;
            DateTime danasPonoc = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 1);
            List<Obrok> danasSkinuti = s.Query<Obrok>().Select(k => k)
                .Where(k => k.Iskoriscen == true)
                .Where(k => k.DatumIskoriscenja != null)
                .Where(k => k.Uplatilac.IdKorisnika == idKorisnika)
                .Where(k => k.DatumIskoriscenja <= DateTime.Now)
                .Where(k => k.DatumIskoriscenja >= danasPonoc).ToList();
            if (danasSkinuti.Count > 0)
                return danasSkinuti.ToList();
            return null;
        }
        
    }
}