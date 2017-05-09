using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.Sloj_podataka
{
    public sealed class Obroci
    {
        private static volatile Obroci instanca;
        private static object zakljucaj = new Object();
        public IList<Obrok> ListaObroka { get; set; }

        private Obroci()
        {
            ListaObroka = new List<Obrok>();
        }

        public static Obroci Instanca
        {
            get
            {
                if (instanca == null)
                {
                    lock (zakljucaj)
                    {
                        if (instanca == null)
                            instanca = new Obroci();
                    }
                }

                return instanca;
            }
        }

    }
}
