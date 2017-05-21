using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class SesijaDto
    {
        public string IdSesije { get; set; }  // guid 
        public int IdKorisnika { get; set; }
        public DateTime DatumPrijavljivanja { get; set; }
        public DateTime ValidnaDo { get; set; }
    }
}