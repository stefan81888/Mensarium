using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class ObjaveDto
    {
        public virtual DateTime DatumObjave { get; set; }
        public virtual string TekstObjave { get; set; }
        public virtual KorisnikDto IdKorisnik { get; set; }
        public virtual MenzaDto Lokacija { get; set; }
    }
}