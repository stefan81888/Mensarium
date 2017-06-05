using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ObrokReklamacijaDto
    {
        public int IdObroka { get; set; }
        public DateTime Datum { get; set; }
        public int IdTipaObroka { get; set; }
        public int idMenza { get; set; }
    }
}