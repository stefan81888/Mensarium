using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Components;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp.Extensions;

namespace MensariumDesktop.Model.Controllers
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

            return u;
        }

    }
}
