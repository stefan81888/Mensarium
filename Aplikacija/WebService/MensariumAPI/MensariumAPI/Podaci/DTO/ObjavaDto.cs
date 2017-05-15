using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class ObjavaDto
    {
        public int IdObjave { get; protected set; }
        public DateTime DatumObjave { get; set; }
        public string TekstObjave { get; set; }
        public KorisnikDto IdKorisnik { get; set; }
        public MenzaDto Lokacija { get; set; }
    }
}