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
using Xamarin.Forms;
using View = Android.Views.View;

namespace Mensarium
{
    class ProfilFragment : Android.Support.V4.App.Fragment
    {
        private Android.Widget.Button sveMenze;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.ProfilFragment, container, false);

            sveMenze = view.FindViewById<Android.Widget.Button>(Resource.Id.sveMenzeDugme);

            sveMenze.Click += SveMenzeOnClick;

            return view;
        }

        private void SveMenzeOnClick(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this.Activity, typeof(SveMenzeActivity));

            StartActivity(intent);
        }
    }
}