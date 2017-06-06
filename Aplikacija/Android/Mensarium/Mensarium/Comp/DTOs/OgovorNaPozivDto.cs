using System;
using System.Collections.Generic;
using System.Linq;
using MensariumDesktop.Model.Components.DTOs;

namespace MensariumAPI.Podaci.DTO
{
    public class OgovorNaPozivDto : PozivanjaPozvaniDto
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
    }
}