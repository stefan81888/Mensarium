using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mensarium.Components;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Api
{
    public static class MUtility
    {
        public static User User_From_KorisnikFullDto(KorisnikFullDto korisnik)
        {
            User u = new User();

            u.AccountType = (User.UserAccountType)korisnik.IdTipaNaloga;
            u.Birthday = korisnik.DatumRodjenja;
            if (korisnik.Email != null) u.Email = korisnik.Email;
            u.FirstName = korisnik.Ime;
            u.LastName = korisnik.Prezime;
            u.PhoneNumber = korisnik.BrojTelefona;
            u.RegistrationDate = korisnik.DatumRegistracije;
            u.UserID = korisnik.IdKorisnika;
            if (korisnik.KorisnickoIme != null) u.Username = korisnik.KorisnickoIme;

            u.IdFakulteta = (int)korisnik.IdFakulteta;
            u.BrojIdexa = korisnik.BrojIndeksa;

            return u;
        }

        public static Faculty Faculty_From_FakultetFullDto(FakultetFullDto f)
        {
            return new Faculty() { FacultyID = f.IdFakultet, Name = f.Naziv };
        }
        public static List<Faculty> FacultyList_FromFakultetiFullDto(List<FakultetFullDto> flist)
        {
            List<Faculty> fl = new List<Faculty>();

            foreach (FakultetFullDto f in flist)
            {
                fl.Add(Faculty_From_FakultetFullDto(f));
            }

            return fl;
        }

        public static Mensa Mensa_From_MenzaFullDto(MenzaFullDto mensa)
        {
            return new Mensa()
            {
                MensaID = mensa.IdMenze,
                Name = mensa.Naziv,
                Location = mensa.Lokacija,
                CurrentlyClosed = mensa.VanrednoNeRadi,
                WorkTime = mensa.RadnoVreme
            };
        }
        public static List<Mensa> MensaList_FromMensaFullDto(List<MenzaFullDto> mlist)
        {
            List<Mensa> ml = new List<Mensa>();

            foreach (var m in mlist)
            {
                ml.Add(Mensa_From_MenzaFullDto(m));
            }

            return ml;
        }
    }
}