using System;
using System.Collections.Generic;
using System.Linq;


namespace MensariumDesktop.Model.Components.DTOs
{
    public class ObrokDanasUplacenDto
    {
        public int IdObroka { get; set; }
        public DateTime DatumUplacivanja { get; set; }
        public int IdTipaObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
    }
}