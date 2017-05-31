using System;
using System.Collections.Generic;
using System.Linq;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class ObjavaReadDto
    {
        public DateTime DatumObjave { get; set; }
        public string TekstObjave { get; set; }
        public int IdKorisnika { get; set; }
        public int IdLokacije { get; set; }
    }
}