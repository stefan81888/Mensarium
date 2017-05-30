using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class KorisnikDodavanjeDto
    {
        public string Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int IdFakulteta { get; set; }
        public string BrojIndeksa { get; set; }
        public DateTime DatumRodjenja { get; set; }
    }
}