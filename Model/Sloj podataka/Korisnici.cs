using Mensarium_Desktop.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensarium_Desktop.Sloj_podataka
{
    public sealed class Korisnici
    {
        private static volatile Korisnici instanca;
        private static object zakljucaj = new Object();
        public IList<Korisnik> ListaKorisnika { get; set; }

        private Korisnici()
        {
            ListaKorisnika = new List<Korisnik>();
        }

        public static Korisnici Instanca
        {
            get
            {
                if (instanca == null)
                {
                    lock (zakljucaj)
                    {
                        if (instanca == null)
                            instanca = new Korisnici();
                    }
                }

                return instanca;
            }
        }

    }
}
