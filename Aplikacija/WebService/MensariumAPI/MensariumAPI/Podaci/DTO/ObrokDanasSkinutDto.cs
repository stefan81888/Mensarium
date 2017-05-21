using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ObrokDanasSkinutDto
    {
        public int IdObroka { get; set; }
        public DateTime DatumIskoriscenja { get; set; }
        public int IdTipaObroka { get; set; }
        public int IdLokacijeIskoriscenja { get; set; }
    }
}