using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mensarium
{

    [Activity(Theme = "@android:style/Theme.DeviceDefault", Label = "Lista svih menzi")]
    public class SveMenzeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SveMenze);

            ActionBar.SetDisplayHomeAsUpEnabled(true);

            List<MenzaItem> lista = new List<MenzaItem>();

            lista.Add(new MenzaItem() { Ime = "Kod elektronski", Lokacija = "Medvedeva 14", Radi = true, Popunjenost = 35 });
            lista.Add(new MenzaItem() { Ime = "Kod pravni", Lokacija = "Neka ulica 23", Radi = true, Popunjenost = 67 });

            var listaView = FindViewById<Android.Widget.ListView>(Resource.Id.SveMenzeListView);
            //listaView.SetScrollContainer(false);

            listaView.Adapter = new MenzeListAdapter(this, lista);
        }

        public override bool OnNavigateUp()
        {
            Finish();
            return true;
        }
    }
}