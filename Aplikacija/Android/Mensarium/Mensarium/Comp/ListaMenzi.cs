using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mensarium.Comp
{
    public class ListaMenzi
    {
        private static ListaMenzi instance;
        private List<MenzaItem> lista = new List<MenzaItem>();

        private ListaMenzi()
        {
            lista.Add(new MenzaItem() { Ime = "Kod elektronski", Lokacija = "Medvedeva 14", Radi = true, Popunjenost = 35 });
            lista.Add(new MenzaItem() { Ime = "Kod pravni", Lokacija = "Neka ulica 23", Radi = true, Popunjenost = 67 });
        }

        public static ListaMenzi InstancaListaMenzi
        {
            get
            {
                if(instance == null) return new ListaMenzi();

                return instance;
            }
        }

        public List<MenzaItem> Lista
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}