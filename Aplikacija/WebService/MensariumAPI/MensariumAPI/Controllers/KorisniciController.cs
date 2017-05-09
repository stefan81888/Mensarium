using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MensariumAPI.Podaci.DTO;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;
using MensariumAPI.Podaci.Sloj_podataka;

namespace MensariumAPI.Controllers
{
    public class KorisniciController : ApiController
    {

        //public string GetString()
        //{
        //    return "Ovo radi??";
        //}

        [HttpGet]
        public KorisnikDto VratiKorisnika()
        {
            ISession s = Podaci.Sloj_podataka.Sesija.VratiSesiju();
            Korisnik k = s.Load<Korisnik>(1);

            return Mapper.Map<Korisnik, KorisnikDto>(k);
        }
    }
}
