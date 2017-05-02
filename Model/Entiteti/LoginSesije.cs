using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Entiteti
{
    public class LoginSesije
    {
        public virtual int IdLogin { get; set; }
        public virtual string IdSesije { get; set; }
        public virtual int DatumPrijavljivanja { get; set; }
        public virtual int ValidnaDo { get; set; }
        public virtual Korisnik KorisnikSesije { get; set; }
    }
}
