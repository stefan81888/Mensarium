using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ValidatorObroka
    {
        public static bool ObrokPostoji(Obrok o)
        {
            return o != null;
        }
    }
}