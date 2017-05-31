using System;
using System.Collections.Generic;
using System.Linq;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class ClientZaRegistracijuDto
    {
        public int DodeljeniId { get; set; }
        public string DodeljenaLozinka { get; set; }
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string NovaLozinka { get; set; }
        public string Telefon { get; set; }
    }
}