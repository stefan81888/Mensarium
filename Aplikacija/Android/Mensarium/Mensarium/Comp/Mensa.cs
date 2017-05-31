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
using Mensarium.Api;

namespace Mensarium.Components
{
    public class Mensa
    {
        public static List<Mensa> Mensas { get; protected set; }

        public static void UpdateMensaList()
        {
            Mensas = MUtility.MensaList_FromMensaFullDto(Api.Api.GetAllMensas());
        }
        public int MensaID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string WorkTime { get; set; }
        public bool CurrentlyClosed { get; set; }
        public int Guzva { get; set; }
    }
}