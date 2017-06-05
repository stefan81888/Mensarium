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
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium.Comp
{
    public class ListaMenzi
    {
        private static ListaMenzi instance;
        private List<MenzaItem> lista = new List<MenzaItem>();



        private ListaMenzi()
        {
            //lista.Add(new MenzaItem() { Ime = "Kod elektronski", Lokacija = "Medvedeva 14", Radi = true, Popunjenost = 35, latiCoo = 43.332193, longCoo = 21.893788, GuzvaNaSalteru = 23});
            //lista.Add(new MenzaItem() { Ime = "Kod pravni", Lokacija = "Neka ulica 23", Radi = true, Popunjenost = 67, latiCoo = 43.3171342, longCoo = 21.8898055, GuzvaNaSalteru = 43});
            //lista.Add(new MenzaItem() { Ime = "Kod medicinski", Lokacija = "Bolnicka BB", Radi = false, Popunjenost = 0, latiCoo = 43.3167453, longCoo = 21.9152952, GuzvaNaSalteru = 0});

            List<MenzaFullDto> listaMenzeFull = Api.Api.GetAllMensas();
            for (int i = 0; i < listaMenzeFull.Count; ++i)
            {
                lista.Add(new MenzaItem() {MenzaFull = listaMenzeFull[i]});

                lista[i].GuzvaFull = new MenzaGuzvaDto();
                lista[i].GuzvaFull.TrenutnaGuzvaZaJelo = Api.Api.CrowdInMensa(lista[i].MenzaFull.IdMenze);
                lista[i].GuzvaFull.TrenutnaGuzvaZaUplatu = Api.Api.CrowdInPaymentCounter(lista[i].MenzaFull.IdMenze);
            }
        }

        public static ListaMenzi InstancaListaMenzi
        {
            get
            {
                if(instance == null) instance = new ListaMenzi();

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