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

namespace Mensarium
{
    public class MenzaItem
    {
        public MenzaFullDto MenzaFull { get; set; }
        public MenzaGuzvaDto GuzvaFull { get; set; }

        public double latiCoo { get; set; }
        public double longCoo { get; set; }
    }
}