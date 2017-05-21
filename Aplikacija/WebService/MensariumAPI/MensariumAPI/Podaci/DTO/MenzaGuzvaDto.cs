using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class MenzaGuzvaDto
    {
        public int IdMenze { get; set; }
        public int TrenutnaGuzvaZaJelo { get; set; }
        public int TrenutnaGuzvaZaUplatu { get; set; }
    }
}