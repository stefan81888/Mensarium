﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mensarium_Desktop.Entiteti;

namespace Mensarium_Desktop.Sloj_podataka
{
    public sealed class Fakulteti
    {
        private static volatile Fakulteti instanca;
        private static object zakljucaj = new Object();
        public IList<Fakultet> ListaFakulteta { get; set; }

        private Fakulteti()
        {
            ListaFakulteta = new List<Fakultet>();
        }

        public static Fakulteti Instanca
        {
            get
            {
                if (instanca == null)
                {
                    lock (zakljucaj)
                    {
                        if (instanca == null)
                            instanca = new Fakulteti();
                    }
                }

                return instanca;
            }
        }

    }
}
