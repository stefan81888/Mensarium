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
using Mensarium.Components;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium
{
    class EventsFragment : Android.Support.V4.App.Fragment
    {
        private Spinner spinerMinutaza;
        private Button kreirajPoziv;
        private Button pozovi;
        private PozivanjaFullDto poziv;
        private TimePicker time;

        private View view = null;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if(view == null)
                view = inflater.Inflate(Resource.Layout.EventsFragment, container, false);

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

            poziv = new PozivanjaFullDto();

            poziv.DatumPoziva = DateTime.Now;
            poziv.VaziDo = new DateTime(2017, 1, 1, time.CurrentHour.IntValue(), time.CurrentMinute.IntValue(), 0);

            poziv.IdPozivaoca = MSettings.CurrentSession.LoggedUser.UserID;

            try
            {
                poziv = Api.Api.KreirajPrazanPoziv(poziv);

                //nadje layout i sakrije ga
                view.FindViewById<LinearLayout>(Resource.Id.pozivNijeKreiran).Visibility = ViewStates.Gone;

                //setuje novi layout
                SetujNoviLayout();
            }
            catch (Exception ex)
            {
                Toast.MakeText(this.Context, ex.Message, ToastLength.Long);
            }
        }

        private void SetujNoviLayout()
        {
            view.FindViewById<RelativeLayout>(Resource.Id.pozivJeKreiran).Visibility = ViewStates.Visible;

            if ((DateTime.Now - poziv.VaziDo).Ticks > 0)
                view.FindViewById<TextView>(Resource.Id.statusPoziva).Text = "Aktivan";
            else
                view.FindViewById<TextView>(Resource.Id.statusPoziva).Text = "Nije aktivan";

            view.FindViewById<TextView>(Resource.Id.vremeKreiranjaPoziva).Text = poziv.DatumPoziva.ToShortTimeString();
            view.FindViewById<TextView>(Resource.Id.vremeTrajanjaPoziva).Text = poziv.VaziDo.ToShortTimeString();
                    
        }
    }

}