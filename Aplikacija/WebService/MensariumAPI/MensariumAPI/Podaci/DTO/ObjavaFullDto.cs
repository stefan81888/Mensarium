using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class ObjavaFullDto
    {
        public int IdObjave { get; set; }
        public DateTime DatumObjave { get; set; }
        public string TekstObjave { get; set; }
        public int IdKorisnika { get; set; }
        public int IdLokacije { get; set; }
    }
}