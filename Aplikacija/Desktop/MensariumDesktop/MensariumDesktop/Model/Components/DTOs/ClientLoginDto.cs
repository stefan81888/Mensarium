using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace MensariumDesktop.Model.Components.DTOs
{
    public class ClientLoginDto //ceo email i pass
    {
        public string KorisnickoIme { get; set; }
        public string Email { get; set; }
        public string Sifra { get; set; }
    }
}