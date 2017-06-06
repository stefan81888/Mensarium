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
    public class ViewHolderNovosti : Java.Lang.Object
    {
        public TextView FeedIme { get; set; }
        public TextView FeedVreme { get; set; }
        public TextView FeedStatus { get; set; }
        public CircleImageView FeedProfilSlika { get; set; }
    }
}