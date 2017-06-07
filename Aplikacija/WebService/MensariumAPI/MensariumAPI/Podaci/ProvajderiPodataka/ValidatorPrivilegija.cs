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
    public class ValidatorPrivilegija
    {
        public enum UserAccountType
        {
            Administrator = 1,
            Menadzer,
            Uplata,
            Naplata,
            Korisnik
        }
        //TO-DO Dinamicki preuzmi iz baze
        public enum UserPrivilegies
        {
            DodavanjeAdmina = 1,
            DodavanjeMenadzer,
            DodavanjeUplata,
            DodavanjeNaplata,
            DodavanjeKorisnik,
            BrisanjeAdmin,
            BrisanjeMenadzer,
            BrisanjeUplata,
            BrisanjeNaplata,
            BrisanjeKorisnik,
            ModifikacijaAdmin,
            ModifikacijaMenadzer,
            ModifikacijaUplata,
            ModifikacijaNaplata,
            ModifikacijaKorisnik,
            CitanjeAdmin,
            CitanjeMenadzer,
            CitanjeUplata,
            CitanjeNaplata,
            CitanjeKorisnik,
            DodavanjeObrok,
            BrisanjeObrok,
            ModifikacijaObrok,
            CitanjeObrok,

            DodavanjeFakultet,
            BrisanjeFakultet,
            ModifikacijaFakultet,
            CitanjeFakultet,

            DodavanjeMenza,
            BrisanjeMenza,
            ModifikacijaMenza,
            CitanjeMenza,
            CitanjeGuzvaMenza,

            PracenjeKorisnika,
            PregledPrivilegija

        }

        public static bool KorisnikImaPrivilegiju(string idSesije, UserPrivilegies privilegija)
        {
            return true;
            ISession s = SesijeProvajder.Sesija;
            LoginSesija trenutnaSesija = s.Query<LoginSesija>().First(k => k.IdSesije == idSesije);
            Korisnik korisnik = trenutnaSesija.KorisnikSesije;
            TipNaloga tipNaloga = korisnik.TipNaloga;
            Privilegija priv = s.Load<Privilegija>((int)privilegija);
            if (tipNaloga.Privilegije.Contains(priv))
                return true;
            return false;
        }


    }
}