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
using DE.Hdodenhof.Circleimageview;

namespace Mensarium.Comp
{
    class ViewHolderMojiPrijatelji : Java.Lang.Object
    {
        public TextView PrijateljIme { get; set; }
        public TextView PrijateljUsername { get; set; }
        public TextView PrijateljFax { get; set; }
        public CircleImageView PrijateljSlika { get; set; }
        public Button Dugme { get; set; }
    }
}