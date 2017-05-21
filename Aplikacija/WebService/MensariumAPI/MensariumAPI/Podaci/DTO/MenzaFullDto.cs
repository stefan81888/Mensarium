using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class MenzaFullDto
    {
        public int IdMenze { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public string RadnoVreme { get; set; }
        public bool VanrednoNeRadi { get; set; }
        
        public int TrenutnaGuzva {get;set;}
 
    }

    public class ObrociKorisnika 
    {
        public int IDKorisnika;
        public int Dorucak;
        public int Rucak;
        public int Vecere;
    }
}