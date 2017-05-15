using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ProvajderPodataka
    {
        public static Korisnik VratiKorisnika(int id)
        {
            ISession s = SesijeProvajder.VratiSesiju();
            Korisnik k = s.Load<Korisnik>(id);
            s.Close();
            return k;
        }
    }
}