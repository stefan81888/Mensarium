using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ObrokPogresnoUplacenDto
    {
        public int IdObroka { get; set; }
        public DateTime DatumUplacivanja { get; set; }
        public int IdTipaObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
    }
}