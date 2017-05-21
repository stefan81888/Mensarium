using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;


namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ValidatorFakulteta
    {
        public static bool FakultetPostoji(Fakultet f)
        {
            return f != null;
        }
    }
}