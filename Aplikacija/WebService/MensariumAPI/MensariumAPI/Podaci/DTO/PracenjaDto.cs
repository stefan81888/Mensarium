using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class PracenjaDto
    {
        public virtual int Id { get; set; } //primarni kljuc
        public virtual Korisnik Pratilac { get; set; }

        public virtual IList<Korisnik> Praceni { get; set; }

        public PracenjaDto()
        {
            Praceni = new List<Korisnik>();
        }
    }
}