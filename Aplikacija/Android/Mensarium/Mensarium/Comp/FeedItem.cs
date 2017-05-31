using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mensarium
{
    public class FeedItem
    {
        public string feedIme { get; set; }
        public string feedVreme { get; set; }
        public string status { get; set; }
        public string profilSlika { get; set; }
    }
}