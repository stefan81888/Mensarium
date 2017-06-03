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
using Mensarium.Comp;
using Xamarin.Forms;
using View = Android.Views.View;
using Mensarium.Components;
using Mensarium.Resources.activities;
using MensariumDesktop.Model.Components.DTOs;

namespace Mensarium
{
    class ProfilFragment : Android.Support.V4.App.Fragment
    {
        private Android.Widget.Button sveMenze;
        public int omiljenaMenza = 0; //index u listi menzi
        private ListaMenzi listaMenzi = ListaMenzi.InstancaListaMenzi;

        private LinearLayout obrociLayout;

        private View view;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
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

            return view;
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
            MenzaItem item = listaMenzi.Lista[indexOmiljene];
            view.FindViewById<TextView>(Resource.Id.ImeMojeMenze).Text = item.Ime;
            view.FindViewById<TextView>(Resource.Id.LokacijaMojeMenze).Text = item.Lokacija;
            if (item.Radi)
                view.FindViewById<TextView>(Resource.Id.DaLiRadiMojaMenza).Text = "Trenutno otvorena!";
            else
                view.FindViewById<TextView>(Resource.Id.DaLiRadiMojaMenza).Text = "Trenutno ne radi!";

            view.FindViewById<TextView>(Resource.Id.GuzvaMojeMenzeText).Text = "Guzva u menzi: " + item.Popunjenost.ToString() + "%"; ;
  
            Android.Widget.ProgressBar bar =
                view.FindViewById<Android.Widget.ProgressBar>(Resource.Id.ProfilMojaMenzaBar);
            bar.Max = 100;
            bar.Progress = item.Popunjenost;
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