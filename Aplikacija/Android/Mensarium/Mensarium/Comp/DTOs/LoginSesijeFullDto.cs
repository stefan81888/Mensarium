using System;
using System.Collections.Generic;
using System.Linq;



namespace MensariumDesktop.Model.Components.DTOs
{
    public class LoginSesijeFullDto
    {
        public virtual int IdLogin { get; set; }
        public virtual string IdSesije { get; set; }
        public virtual DateTime DatumPrijavljivanja { get; set; }
        public virtual DateTime ValidnaDo { get; set; }
        public virtual int IdKorisnikaSesije { get; set; }
    }
}