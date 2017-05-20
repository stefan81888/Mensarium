using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ClientZaRegistracijuUpitDto
    {
        public int DodeljeniId { get; set; }
        public string DodeljenaLozinka { get; set; }
    }
    
    public class ClientZaRegistracijuDto
    {
        public int DodeljeniId { get; set; }
        public string DodeljenaLozinka { get; set; }
        public int IdKorisnika { get; protected set; }
        public string KorisnsickoIme { get; set; }
        public string Email { get; set; }
    }
}