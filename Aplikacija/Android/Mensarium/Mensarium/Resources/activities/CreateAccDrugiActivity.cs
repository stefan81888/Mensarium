using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp.Extensions;

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "CreateAccDrugiActivity")]
    public class CreateAccDrugiActivity : Activity
    {
        private Button kreirajNalog;
        private AlertDialog dialogKraj;
        private AlertDialog dialogCekaj;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.createAccDrugi);

            kreirajNalog = FindViewById<Button>(Resource.Id.createDugme);
            kreirajNalog.Click += KreirajNalogOnClick;
        }

        private void KreirajNalogOnClick(object sender, EventArgs eventArgs)
        {
            if (ValidacijaUnosa())
            {
                Thread novaNit = new Thread(FunkcijaUNovuNit);
                novaNit.Start();

                dialogKraj = new AlertDialog.Builder(this).Create();
                dialogKraj.SetTitle("Uspesno ste kreirali nalog!");
                dialogKraj.SetMessage("Sada cete biti vraceni na stranicu za prijavljivanje.");
                dialogKraj.SetButton("U redu", OkDugme);
                //dialog.Show();

                dialogCekaj = new AlertDialog.Builder(this).Create();
                dialogCekaj.SetTitle("Provera podataka");
                dialogCekaj.SetMessage("Molimo sacekajte!");
                //dialogCekaj.Show();
            }
        }

        private void FunkcijaUNovuNit()
        {
            ClientZaRegistracijuDto reg = new ClientZaRegistracijuDto();

            reg.DodeljeniId = Intent.GetIntExtra("dodeljenID", 0);
            reg.DodeljenaLozinka = Intent.GetStringExtra("dodeljenaLozinka");

            reg.KorisnickoIme = FindViewById<TextView>(Resource.Id.EditTextUsername).Text;
            reg.Email = FindViewById<TextView>(Resource.Id.EditTextEmail).Text;
            reg.NovaLozinka = FindViewById<TextView>(Resource.Id.EditTextPassword).Text;
            reg.Telefon = FindViewById<TextView>(Resource.Id.EditTextPhone).Text;

            try
            {
                RunOnUiThread(() => dialogCekaj.Show());
                Api.Api.AndroidUserRegistration(reg);
                RunOnUiThread(() => dialogCekaj.Dismiss());

                RunOnUiThread(() => dialogKraj.Show());
            }
            catch (Exception ex)
            {
                //Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                RunOnUiThread(() => Toast.MakeText(this, ex.Message, ToastLength.Short).Show());
            }
        }

        private void OkDugme(object sender, DialogClickEventArgs dialogClickEventArgs)
        {
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
        }

        private bool ValidacijaUnosa()
        {
            bool validno = true;
            string greska = "";

            //username
            if (FindViewById<TextView>(Resource.Id.EditTextUsername).Text.Equals(string.Empty))
            {
                greska += "Unesite username!\n";
                validno = false;
            }

            //email
            string email = FindViewById<TextView>(Resource.Id.EditTextEmail).Text;
            string emailPatern = "[a-zA-Z0-9._-]+@[a-z]+\\.+[a-z]+";
            if (!email.Matches(emailPatern))
            {
                greska += "Email nije validan!\n";
                validno = false;
            }

            //passwordi
            string pass = FindViewById<TextView>(Resource.Id.EditTextPassword).Text;
            string passA = FindViewById<TextView>(Resource.Id.EditTextPasswordAgain).Text;
            if (!pass.Equals(passA))
            {
                greska += "Sifre nisu iste!\n";
                validno = false;
            }

            //telefon
            if (FindViewById<TextView>(Resource.Id.EditTextPhone).Text.Equals(string.Empty))
            {
                greska += "Unesite telefon!\n";
                validno = false;
            }

            if(!greska.Equals(string.Empty))
                Toast.MakeText(this, greska, ToastLength.Long).Show();

            return validno;
        }
    }
}