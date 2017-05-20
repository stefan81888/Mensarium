using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class LoginSesijeFullDto
    {
        public virtual int IdLogin { get; protected set; }
        public virtual string IdSesije { get; set; }
        public virtual DateTime DatumPrijavljivanja { get; set; }
        public virtual DateTime ValidnaDo { get; set; }
        public virtual int IdKorisnikaSesije { get; set; }
    }
}