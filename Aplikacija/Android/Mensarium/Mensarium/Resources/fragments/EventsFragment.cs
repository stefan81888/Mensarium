using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Widget;
using Java.Util;
using Mensarium.Comp;
using Mensarium.Components;
using Mensarium.Resources.activities;
using Mensarium.Resources.adapters;
using MensariumAPI.Podaci.DTO;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium
{
    class EventsFragment : Android.Support.V4.App.Fragment
    {
        private PozivanjaFullDto poziv;

        private ViewHolderEvents holder;

        private View view = null;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (view == null)
            {
                view = inflater.Inflate(Resource.Layout.EventsFragment, container, false);

                var time = view.FindViewById<TimePicker>(Resource.Id.timePicker1);
                var DugmeZaKreiranjePoziva = view.FindViewById<Button>(Resource.Id.kreirajPozivDugme);
                var DugmePozovi = view.FindViewById<Button>(Resource.Id.posaljiPozivDugme);
                var DugmeOdgovori = view.FindViewById<Button>(Resource.Id.odgovoriNaPoziveDugme);
                var Swipe = view.FindViewById<SwipeRefreshLayout>(Resource.Id.swipeEvents);

                var vh = new ViewHolderEvents()
                {
                    EvenTimePicker = time,
                    Kreiraj = DugmeZaKreiranjePoziva,
                    Pozovi = DugmePozovi,
                    Odgovori = DugmeOdgovori,
                    Swipe = Swipe
                };

                view.Tag = vh;

                ObnoviPoziv();
            }

            holder = (ViewHolderEvents) view.Tag;

            //prebaci time u 24h
            holder.EvenTimePicker.SetIs24HourView(Java.Lang.Boolean.True);

            //nadji button za kreiranje i dodeli click
            holder.Kreiraj.Click += KreirajPozivOnClick;

            holder.Pozovi.Click += PozoviOnClick;

            holder.Odgovori.Click += OdgovoriNaPoziveOnClick;

            holder.Swipe.Refresh += SwipeOnRefresh;

            view.FindViewById<LinearLayout>(Resource.Id.ponistiPozivLayout).Click += PonistiPozivClick;

            return view;
        }

        private void ObnoviPoziv()
        {
            var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);

            int idpoziva = prefs.GetInt("idPoziva", -1);

            if (idpoziva != -1)
            {
                try
                {
                    poziv = Api.Api.PozivNaOsnovuIda(idpoziva);
                    SetujNoviLayout();
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this.Context, ex.Message, ToastLength.Long).Show();
                }
            }
        }

        public override void OnPause()
        {
            base.OnPause();

            if (poziv != null)
            {
                var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                var prefEditor = prefs.Edit();
                prefEditor.PutInt("idPoziva", poziv.IdPoziva);
                prefEditor.Commit();
            }
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            if (poziv != null)
            {
                var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                var prefEditor = prefs.Edit();
                prefEditor.PutInt("idPoziva", poziv.IdPoziva);
                prefEditor.Commit();
            }
        }

        private void PonistiPozivClick(object sender, EventArgs eventArgs)
        {
            var alert = new AlertDialog.Builder(this.Context);
            alert.SetTitle("Ponisti poziv?");
            alert.SetMessage("Da li ste sigurni da zelite da ponistite poziv?");

            alert.SetPositiveButton("Da", (o, args) =>
            {

                this.poziv = null;

                view.FindViewById<RelativeLayout>(Resource.Id.pozivJeKreiran).Visibility = ViewStates.Gone;
                view.FindViewById<LinearLayout>(Resource.Id.pozivNijeKreiran).Visibility = ViewStates.Visible;

                var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                var prefEditor = prefs.Edit();
                prefEditor.PutInt("idPoziva", -1);
                prefEditor.Commit();
            });

            alert.SetNegativeButton("Ne", (o, args) => alert.Dispose());

            alert.Show();
        }

        private void SwipeOnRefresh(object sender, EventArgs eventArgs)
        {
            var lista = view.FindViewById<ListView>(Resource.Id.PozvaniListView);
            try
            {
                List<OgovorNaPozivDto> listaOdgovora;
                if (poziv != null)
                {
                    listaOdgovora = Api.Api.ObavestiOOdgovorima(poziv.IdPoziva);
                    lista.Adapter = new OdgovorListAdapter(this, listaOdgovora);
                }
                holder.Swipe.Refreshing = false;
            }
            catch (Exception ex)
            {
                Toast.MakeText(this.Context, ex.Message, ToastLength.Long).Show();
                holder.Swipe.Refreshing = false;
            }
        }

        private void OdgovoriNaPoziveOnClick(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this.Context, typeof(ActivityPozvanSam));
            StartActivity(intent);
        }

        private void PozoviOnClick(object sender, EventArgs eventArgs)
        {
            //setujemo intent i startujemo activity
            var intent = new Intent(this.Activity, typeof(PozoviPrijateljaActivity));
            intent.PutExtra("IdPoziva", poziv.IdPoziva);
            StartActivity(intent);
        }

        private void KreirajPozivOnClick(object sender, EventArgs eventArgs)
        {
            NapuniPoziv();
            
            if (true)//(poziv.VaziDo - DateTime.Now).Ticks > 0 && ValidnoVreme(poziv.VaziDo))
            {
                try
                {
                    poziv = Api.Api.KreirajPrazanPoziv(poziv);

                    var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                    var prefEditor = prefs.Edit();
                    prefEditor.PutInt("idPoziva", poziv.IdPoziva);
                    prefEditor.Commit();

                    //setuje novi layout
                    SetujNoviLayout();
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this.Context, ex.Message, ToastLength.Long);
                }
            }
            else
            {
                Toast.MakeText(this.Context, "Nije validno vreme poziva!", ToastLength.Long).Show();
            }
        }

        private void NapuniPoziv()
        {
            poziv = new PozivanjaFullDto();

            poziv.DatumPoziva = DateTime.Now.ToUniversalTime();
            
            //poziv.VaziDo = DateTime.Now;
            poziv.VaziDo = new DateTime(DateTime.Now.Year, DateTime.Now.Day, DateTime.Now.Month, holder.EvenTimePicker.CurrentHour.IntValue(), holder.EvenTimePicker.CurrentMinute.IntValue(), 0).ToUniversalTime();

            poziv.IdPozivaoca = MSettings.CurrentSession.LoggedUser.UserID;
        }

        private bool ValidnoVreme(DateTime p)
        {
            DateTime dorucakP = new DateTime(p.Year, p.Month, p.Day, 7, 30, 0);
            DateTime dorucakZ = new DateTime(p.Year, p.Month, p.Day, 9, 30, 0);

            DateTime rucakP = new DateTime(p.Year, p.Month, p.Day, 12, 30, 0);
            DateTime rucakZ = new DateTime(p.Year, p.Month, p.Day, 15, 30, 0);

            DateTime veceraP = new DateTime(p.Year, p.Month, p.Day, 17, 00, 0);
            DateTime veceraZ = new DateTime(p.Year, p.Month, p.Day, 20, 00, 0);

            if ((p >= dorucakP && p <= dorucakZ) || (p >= rucakP && p <= rucakZ) || (p >= veceraP && p <= veceraZ))
                return true;

            return false;
        }

        private void SetujNoviLayout()
        {
            view.FindViewById<LinearLayout>(Resource.Id.pozivNijeKreiran).Visibility = ViewStates.Gone;
            view.FindViewById<RelativeLayout>(Resource.Id.pozivJeKreiran).Visibility = ViewStates.Visible;
            var tx = view.FindViewById<TextView>(Resource.Id.statusPoziva);

            if (poziv.VaziDo > DateTime.Now)
            {
                tx.Text = "Aktivan";
                tx.SetTextColor(Color.ParseColor("#4ee07d"));
            }
            else
            {
                tx.Text = "Nije aktivan";
                tx.SetTextColor(Color.ParseColor("#ba1d1d"));
            }

            view.FindViewById<TextView>(Resource.Id.vremeKreiranjaPoziva).Text = poziv.DatumPoziva.ToShortTimeString();
            view.FindViewById<TextView>(Resource.Id.vremeTrajanjaPoziva).Text = poziv.VaziDo.ToShortTimeString();
                    
        }
    }

}