using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class KorisnikFollowDto
    {
        public int IdKorisnika { get; protected set; }
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Fakultet { get; set; }
        public bool Zapracen {get;set;} // ???
        //slika
    }
}