using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class ObrokPogresnoSkinutDto
    {
        public int IdObroka { get; set; }
        public DateTime DatumIskoriscenja { get; set; }
        public int IdTipaObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
    }
}