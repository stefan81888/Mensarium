using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace MensariumDesktop.Model.Components.DTOs
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