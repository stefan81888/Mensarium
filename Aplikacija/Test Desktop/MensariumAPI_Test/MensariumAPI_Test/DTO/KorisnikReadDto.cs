using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class KorisnikReadDto
    {
        public int IdKorisnika { get; protected set; }
        public string KorisnsickoIme { get; set; }
        public string Email { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string BrojTelefona { get; set; }
        public string BrojIndeksa { get; set; }
        public DateTime DatumVaziDo { get; set; }
        public bool AktivanNalog { get; set; } //VAZNO: u bazi je tiny int
        public int IdTipaNaloga { get; set; }
        public int IdFakulteta { get; set; }
    }
}