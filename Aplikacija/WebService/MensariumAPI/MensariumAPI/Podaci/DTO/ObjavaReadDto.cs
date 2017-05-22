using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ObjavaReadDto
    {
        public DateTime DatumObjave { get; set; }
        public string TekstObjave { get; set; }
        public int IdKorisnika { get; set; }
        public int IdLokacije { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
    }
}