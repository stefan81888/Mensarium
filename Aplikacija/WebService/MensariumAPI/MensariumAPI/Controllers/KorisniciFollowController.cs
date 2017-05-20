using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using MensariumAPI.Podaci.ProvajderiPodataka;

namespace MensariumAPI.Controllers
{
    public class KorisniciFollowController : ApiController
    {
        [HttpGet]
        public KorisnikFollowDto VratiKorisnikaFollow(int id)
        {
            SesijeProvajder.OtvoriSesiju();

            Korisnik k = ProvajderPodataka.VratiKorisnika(id);
            KorisnikFollowDto korisnik = new KorisnikFollowDto();
            if (Validator.KorisnikPostoji(k))
            {
                //korisnik.IdKorisnika = k.IdKorisnika; ???
                korisnik.KorisnickoIme = k.KorisnickoIme;
                korisnik.Ime = k.Ime;
                korisnik.Prezime = k.Prezime;
                korisnik.Fakultet = k.StudiraFakultet.Naziv;
                //korisnik.Zapracen ???
            }

            SesijeProvajder.ZatvoriSesiju();
            return korisnik;
        }

    }
}
