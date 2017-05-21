using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class SesijaDto
    {
        public string IdSesije { get; set; }  // guid 
        public int IdKorisnika { get; set; }
        public DateTime DatumPrijavljivanja { get; set; }
        public DateTime ValidnaDo { get; set; }
    }
}