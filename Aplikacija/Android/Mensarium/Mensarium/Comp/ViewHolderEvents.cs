using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;

namespace Mensarium.Comp
{
    class ViewHolderEvents : Java.Lang.Object
    {
        public TimePicker EvenTimePicker { get; set; }
        public Button Kreiraj { get; set; }
        public Button Pozovi { get; set; }
        public Button Odgovori { get; set; }
        public SwipeRefreshLayout Swipe { get; set; }
    }
}