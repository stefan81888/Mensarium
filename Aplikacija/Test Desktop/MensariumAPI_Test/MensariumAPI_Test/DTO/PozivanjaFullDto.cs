using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class PozivanjaFullDto
    {
        public int IdPoziva { get; protected set; }
        public DateTime DatumPoziva { get; set; }
        public DateTime VaziDo { get; set; }

        //Pozivanja -> Korisnici
        public int IdPozivaoca { get; set; }
        
    }
}