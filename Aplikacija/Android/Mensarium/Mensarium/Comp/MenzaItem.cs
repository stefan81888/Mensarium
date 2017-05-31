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

namespace Mensarium
{
    public class MenzaItem
    {
        public string Ime { get; set; }
        public string Lokacija { get; set; }
        public bool Radi { get; set; }
        public int Popunjenost { get; set; }
    }
}