using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Controllers;
using MensariumDesktop.Model.Components.DTOs;

namespace MensariumDesktop.Model.Components
{
    public class Mensa
    {
        public static List<Mensa> Mensas { get; protected set; }

        public static void UpdateMensaList()
        {
            Mensas = MUtility.MensaList_FromMensaFullDto(Api.GetAllMensas());
            Mensas.Sort((x,y) => x.MensaID.CompareTo(y.MensaID));
        }
        public int MensaID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string WorkTime { get; set; }
        public bool CurrentlyClosed { get; set; }
        //gps coordinates
        public double GPSLong { get; set; }
        public double GPSLat { get; set; }

        public static void LoadPrices()
        {
            KorisnikStanjeDto k = Api.GetMealPrices();
            MSettings.PriceBreakfast = k.BrojDorucka;
            MSettings.PriceLunch = k.BrojRuckova;
            MSettings.PriceDinner = k.BrojVecera;
        }
    }
}
