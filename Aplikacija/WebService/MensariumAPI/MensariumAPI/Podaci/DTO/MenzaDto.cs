using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class MenzaDto
    {
        public virtual int IdMenza { get; set; }
        public virtual string Naziv { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual bool VanrednoNeRadi { get; set; } // u bazi je tinyint

        public virtual IList<Objave> Objava { get; set; }
        public virtual IList<Menza> Uplaceni { get; set; }
        public virtual IList<Menza> Iskorisceni { get; set; }

        public MenzaDto()
        {
            Objava = new List<Objave>();
            Uplaceni = new List<Menza>();
            Iskorisceni = new List<Menza>();
        }
    }
}