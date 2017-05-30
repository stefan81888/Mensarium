using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace MensariumDesktop.Model.Components.DTOs
{
    public class PozivanjaPozvaniDto
    {
        public bool OdgovorPozvanog { get; set; }
        public int IdPozvanog { get; set; }
        public int IdPoziva { get; set; }
    }
}