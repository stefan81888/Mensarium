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
using Java.Util;

namespace Mensarium
{
    class EventsFragment : Android.Support.V4.App.Fragment
    {
        private Spinner spinerMinutaza;
        private Button kreirajPoziv;
        private Button pozovi;
        private Poziv poziv = new Poziv();
        private TimePicker time;

        private View view = null;
        private int[] minuti = {5, 10, 15, 20, 30, 60};

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if(view == null)
                view = inflater.Inflate(Resource.Layout.EventsFragment, container, false);

            //napuni combobox sa minutazu
            spinerMinutaza = view.FindViewById<Spinner>(Resource.Id.comboBox);
            spinerMinutaza.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(spinner_itemSelected);
            var adapter = ArrayAdapter.CreateFromResource(this.Context, Resource.Array.zaKolikoMinuta,
                Android.Resource.Layout.SimpleSpinnerItem);

            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinerMinutaza.Adapter = adapter;
            //

            //prebaci time u 24h
            time = view.FindViewById<TimePicker>(Resource.Id.timePicker1);
            time.SetIs24HourView(Java.Lang.Boolean.True);

            //nadji button za kreiranje i dodeli click
            kreirajPoziv = view.FindViewById<Button>(Resource.Id.kreirajPozivDugme);
            kreirajPoziv.Click += KreirajPozivOnClick;

            pozovi = view.FindViewById<Button>(Resource.Id.posaljiPozivDugme);
            pozovi.Click += PozoviOnClick;

            return view;
        }

        private void PozoviOnClick(object sender, EventArgs eventArgs)
        {
            //setujemo intent i startujemo activity
            var intent = new Intent(this.Activity, typeof(PozoviPrijateljaActivity));
            StartActivity(intent);
        }

        private void KreirajPozivOnClick(object sender, EventArgs eventArgs)
        {
            //nadje layout i sakrije ga
            view.FindViewById<LinearLayout>(Resource.Id.pozivNijeKreiran).Visibility = ViewStates.Gone;

            //poziv
            poziv.status = true;
            //int sati = time.CurrentHour.IntValue();
            poziv.vremePoziva = new DateTime(2017, 1, 1, time.CurrentHour.IntValue(), time.CurrentMinute.IntValue(), 0);
            poziv.vremeKreiranja = DateTime.Now;

            //setuje novi layout
            SetujNoviLayout();
        }

        private void SetujNoviLayout()
        {
            view.FindViewById<RelativeLayout>(Resource.Id.pozivJeKreiran).Visibility = ViewStates.Visible;

            if(poziv.status)
                view.FindViewById<TextView>(Resource.Id.statusPoziva).Text = "Aktivan";
            else
                view.FindViewById<TextView>(Resource.Id.statusPoziva).Text = "Nije aktivan";

            view.FindViewById<TextView>(Resource.Id.vremePoziva).Text = poziv.vremePoziva.ToShortTimeString();
            view.FindViewById<TextView>(Resource.Id.vremeKreiranjaPoziva).Text = poziv.vremeKreiranja.ToShortTimeString();

            
            if(poziv.kolikoMinutaTraje != 60)
                view.FindViewById<TextView>(Resource.Id.vremeTrajanjaPoziva).Text =
                    poziv.vremeKreiranja.Add(new TimeSpan(0, poziv.kolikoMinutaTraje, 0)).ToShortTimeString();
            else
                view.FindViewById<TextView>(Resource.Id.vremeTrajanjaPoziva).Text =
                    poziv.vremeKreiranja.Add(new TimeSpan(1, 0, 0)).ToShortTimeString();
                    
        }

        private void spinner_itemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner spinner = (Spinner)sender;
            poziv.kolikoMinutaTraje = this.minuti[spinner.GetItemIdAtPosition(e.Position)];

            //string toast = string.Format("Poziv ce biti kreiran za: {0}", spinner.GetItemAtPosition(e.Position));
            //Toast.MakeText(this.Context, toast, ToastLength.Long).Show();
        }
    }

}