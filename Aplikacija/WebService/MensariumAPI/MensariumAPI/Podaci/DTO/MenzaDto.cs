using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class MenzaDto
    {
        public virtual string Naziv { get; set; }
        public virtual string Lokacija { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual bool VanrednoNeRadi { get; set; } // u bazi je tinyint

        public virtual IList<ObjaveDto> ObjaveKorisnika { get; set; }
        public virtual IList<MenzaDto> Uplaceni { get; set; }
        public virtual IList<MenzaDto> Iskorisceni { get; set; }

        public MenzaDto()
        {
            ObjaveKorisnika = new List<ObjaveDto>();
            Uplaceni = new List<MenzaDto>();
            Iskorisceni = new List<MenzaDto>();
        }
    }
}