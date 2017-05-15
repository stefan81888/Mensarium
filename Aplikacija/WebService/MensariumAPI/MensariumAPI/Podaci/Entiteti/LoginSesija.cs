using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumAPI.Podaci.Entiteti
{
    public class LoginSesija
    {
        public virtual int IdLogin { get; protected set; }
        public virtual string IdSesije { get; set; }
        public virtual DateTime DatumPrijavljivanja { get; set; }
        public virtual DateTime ValidnaDo { get; set; }

        //LoginSesija -> Korisnici
        public virtual Korisnik KorisnikSesije { get; set; }
    }
}
