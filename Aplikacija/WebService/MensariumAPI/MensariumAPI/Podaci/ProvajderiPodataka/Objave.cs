using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.ProvajderiPodataka
{
    public sealed class Objava
    {
        private static volatile Objava instanca;
        private static object zakljucaj = new Object();
        public IList<Objava> ListaObjava { get; set; }

        private Objava()
        {
            ListaObjava = new List<Objava>();
        }

        public static Objava Instanca
        {
            get
            {
                if (instanca == null)
                {
                    lock (zakljucaj)
                    {
                        if (instanca == null)
                            instanca = new Objava();
                    }
                }

                return instanca;
            }
        }

    }
}
