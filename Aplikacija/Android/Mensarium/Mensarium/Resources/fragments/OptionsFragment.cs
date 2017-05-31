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
    class OptionsFragment : Android.Support.V4.App.Fragment
    {
        Button btn;
        private View view;
        private LinearLayout ln;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.OptionsFragment, container, false);

            ln = view.FindViewById<LinearLayout>(Resource.Id.layoutzaprobu);

            view.FindViewById<TextView>(Resource.Id.optionsText).Text = "Options Here";

            btn = view.FindViewById<Button>(Resource.Id.dugmezaprobu);
            btn.Click += BtnOnClick;

            return view;
        }

        private void BtnOnClick(object sender, EventArgs eventArgs)
        {
            view.FindViewById<TextView>(Resource.Id.optionsText).Text = "Promena";

            TextView detence = new TextView(view.Context);
            detence.Text = "Nesto";
            detence.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent,
                ViewGroup.LayoutParams.WrapContent);

            ln.AddView(detence);
        }
    }
}