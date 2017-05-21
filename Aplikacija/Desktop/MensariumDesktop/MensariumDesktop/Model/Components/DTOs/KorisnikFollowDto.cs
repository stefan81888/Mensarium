using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class KorisnikFollowDto
    {
        public int IdKorisnika { get; set; }
        public string KorisnickoIme { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Fakultet { get; set; }
        public bool Zapracen {get;set;} // ???
        //slika
    }
}