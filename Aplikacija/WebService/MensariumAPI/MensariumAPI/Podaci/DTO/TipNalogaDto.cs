using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class TipNalogaDto
    {
        public virtual int IdTip { get; set; }
        public virtual string Naziv { get; set; }

        public virtual IList<Privilegija> Privilegije { get; set; }
        public virtual IList<Korisnik> Korisnici { get; set; }

        public TipNalogaDto()
        {
            Korisnici = new List<Korisnik>();
            Privilegije = new List<Privilegija>();
        }
    }
}