using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class LoginSesijeDto
    {
        public virtual string IdSesije { get; set; }
        public virtual int DatumPrijavljivanja { get; set; }
        public virtual int ValidnaDo { get; set; }
        public virtual KorisnikDto KorisnikSesije { get; set; }
    }
}