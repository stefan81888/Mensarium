using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mensarium.Comp;
using Xamarin.Forms;
using View = Android.Views.View;
using Mensarium.Components;
using Mensarium.Resources.activities;
using MensariumDesktop.Model.Components.DTOs;
using Android.Support.V4.Widget;
using DE.Hdodenhof.Circleimageview;

namespace Mensarium
{
    class ProfilFragment : Android.Support.V4.App.Fragment
    {
        private Android.Widget.Button sveMenze;
        public int omiljenaMenza = 0; //index u listi menzi
        private ListaMenzi listaMenzi = ListaMenzi.InstancaListaMenzi;

        private SwipeRefreshLayout swipe;

        private LinearLayout obrociLayout;

        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            if (view == null)
            {
                view = inflater.Inflate(Resource.Layout.ProfilFragment, container, false);

                NapuniLabele();

                //dugme sve menze.. Dodat click
                sveMenze = view.FindViewById<Android.Widget.Button>(Resource.Id.sveMenzeDugme);
                sveMenze.Click += SveMenzeOnClick;

                //napunimo omiljenu menzu.. Po defaultu index 0
                var prefs = Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                this.omiljenaMenza = prefs.GetInt("OmiljenaMezna", omiljenaMenza);
                SetujOmiljenuMenzu(omiljenaMenza);

                obrociLayout = view.FindViewById<LinearLayout>(Resource.Id.profilObrociLayout);
                obrociLayout.Click += ObrociLayoutOnClick;

                swipe = view.FindViewById<SwipeRefreshLayout>(Resource.Id.swipeProfilPage);
                swipe.Refresh += Swipe_Refresh;

                SetujSliku();
            }
            return view;
        }

        private void SetujSliku()
        {
            try
            {
                var slika = view.FindViewById<CircleImageView>(Resource.Id.profilSlika);

                var bitmap = Api.Api.GetCurrentUserImage();
                slika.SetImageBitmap(bitmap);
            }
            catch (Exception ex)
            {
                Toast.MakeText(this.Activity, ex.Message, ToastLength.Long).Show();
            }
        }

        private void Swipe_Refresh(object sender, EventArgs e)
        {
            NapuniLabeleSaObrocima();
            SetujOmiljenuMenzu(omiljenaMenza);

            swipe.Refreshing = false;
        }

        private void NapuniLabele()
        {
            //ime i prezime
            view.FindViewById<TextView>(Resource.Id.profilTextImeIPrezime).Text =
                MSettings.CurrentSession.LoggedUser.FirstName + " " + MSettings.CurrentSession.LoggedUser.LastName;

            FakultetFullDto fax = Api.Api.GetFacultyInfo(MSettings.CurrentSession.LoggedUser.IdFakulteta);

            //univezitet
            view.FindViewById<TextView>(Resource.Id.profilTextFakultet).Text = fax.Naziv;

            //broj idexa
            view.FindViewById<TextView>(Resource.Id.profilTextBrIndexa).Text =
                MSettings.CurrentSession.LoggedUser.BrojIdexa;

            //obroci
            NapuniLabeleSaObrocima();
        }

        private void NapuniLabeleSaObrocima()
        {
            KorisnikStanjeDto stanje = Api.Api.KorisnikovoStanjeObroka(MSettings.CurrentSession.LoggedUser.UserID);

            view.FindViewById<TextView>(Resource.Id.profilObrociBrojDorucka).Text = stanje.BrojDorucka.ToString();
            view.FindViewById<TextView>(Resource.Id.profilObrociBrojRucka).Text = stanje.BrojRuckova.ToString();
            view.FindViewById<TextView>(Resource.Id.profilObrociBrojVecera).Text = stanje.BrojVecera.ToString();
        }

        private void ObrociLayoutOnClick(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this.Activity, typeof(UplacivanjeObroka));

            StartActivity(intent);
        }

        public void SetujOmiljenuMenzu(int indexOmiljene)
        {
            listaMenzi.RefreshLista();
            MenzaItem item = listaMenzi.Lista[indexOmiljene];
            view.FindViewById<TextView>(Resource.Id.ImeMojeMenze).Text = item.MenzaFull.Naziv;
            view.FindViewById<TextView>(Resource.Id.LokacijaMojeMenze).Text = item.MenzaFull.Lokacija;

            var radili = view.FindViewById<TextView>(Resource.Id.DaLiRadiMojaMenza);
            if (item.MenzaFull.VanrednoNeRadi)
            {
                radili.Text = "Vanredno NE RADI!";
                radili.SetTextColor(Android.Graphics.Color.ParseColor("#ba1d1d"));
            }
            else
                view.FindViewById<TextView>(Resource.Id.DaLiRadiMojaMenza).Text = "Trenutno ne radi!";

            view.FindViewById<TextView>(Resource.Id.GuzvaMojeMenzeText).Text = "Guzva u menzi: " + item.GuzvaFull.TrenutnaGuzvaZaJelo.ToString() + "%"; ;
            view.FindViewById<TextView>(Resource.Id.GuzvaNaSalteruMojeMenzeText).Text = "Guzva na salteru: " +
                                                                                        item.GuzvaFull.TrenutnaGuzvaZaUplatu.ToString() +
                                                                                        "%";
  
            Android.Widget.ProgressBar bar =
                view.FindViewById<Android.Widget.ProgressBar>(Resource.Id.ProfilMojaMenzaBar);
            bar.Max = 100;
            bar.Progress = item.GuzvaFull.TrenutnaGuzvaZaJelo;

            bar = view.FindViewById<Android.Widget.ProgressBar>(Resource.Id.GuzvaNaSalteruMojaMenzaBar);
            bar.Max = 100;
            bar.Progress = item.GuzvaFull.TrenutnaGuzvaZaUplatu;
        }

        private void SveMenzeOnClick(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this.Activity, typeof(SveMenzeActivity));
            StartActivityForResult(intent, 0);

            
            //var prefs = Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
            //SetujOmiljenuMenzu(prefs.GetInt("OmiljenaMezna", omiljenaMenza));
        }

        public override void OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == 0)
            {
                var prefs = Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
                this.omiljenaMenza = prefs.GetInt("OmiljenaMezna", omiljenaMenza);
                SetujOmiljenuMenzu(omiljenaMenza);
            }
        }
    }
}