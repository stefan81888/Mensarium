using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public static class Validator
    {
        public static bool KorisnikPostoji(Korisnik k)
        {
            return k != null;
        }
    }
}