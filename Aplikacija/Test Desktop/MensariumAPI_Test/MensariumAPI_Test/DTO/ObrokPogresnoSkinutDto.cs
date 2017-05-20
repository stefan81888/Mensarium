using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ObrokPogresnoSkinutDto
    {
        public int IdObroka { get; protected set; }
        public DateTime DatumIskoriscenja { get; set; }
        public int IdTipaObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
    }
}