using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;
using NHibernate;
namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public class ValidatorMenze
    {
        public static bool MenzaPostoji(Menza m)
        {
            return m != null;
        }
    }
}