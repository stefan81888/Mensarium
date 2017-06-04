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
        public double GpsLong { get; set; }
        public double GpsLat { get; set; }
    }

    
}