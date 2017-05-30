using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MensariumDesktop.Model.Components.DTOs
{
    public class MenzaFullDto
    {
        public int IdMenze { get; set; }
        public string Naziv { get; set; }
        public string Lokacija { get; set; }
        public string RadnoVreme { get; set; }
        public bool VanrednoNeRadi { get; set; }
 
    }

    
}