using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Sloj_podataka
{
    public sealed class Menze
    {
        private static volatile Menze instanca;
        private static object zakljucaj = new Object();
        public IList<Menza> ListaMenzi { get; set; }

        private Menze()
        {
            ListaMenzi = new List<Menza>();
        }

        public static Menze Instanca
        {
            get
            {
                if (instanca == null)
                {
                    lock (zakljucaj)
                    {
                        if (instanca == null)
                            instanca = new Menze();
                    }
                }

                return instanca;
            }
        }

    }
}
