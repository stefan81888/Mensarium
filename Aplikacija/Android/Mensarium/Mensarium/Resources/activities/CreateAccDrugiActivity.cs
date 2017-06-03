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
using MensariumDesktop.Model.Components.DTOs;
using RestSharp.Extensions;

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "CreateAccDrugiActivity")]
    public class CreateAccDrugiActivity : Activity
    {
        private Button kreirajNalog;

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

                ClientZaRegistracijuDto reg = new ClientZaRegistracijuDto();

                reg.DodeljeniId = Intent.GetIntExtra("dodeljenID", 0);
                reg.DodeljenaLozinka = Intent.GetStringExtra("dodeljenaLozinka");

                reg.KorisnickoIme = FindViewById<TextView>(Resource.Id.EditTextUsername).Text;
                reg.Email = FindViewById<TextView>(Resource.Id.EditTextEmail).Text;
                reg.NovaLozinka = FindViewById<TextView>(Resource.Id.EditTextPassword).Text;
                reg.Telefon = FindViewById<TextView>(Resource.Id.EditTextPhone).Text;

                try
                {
                    if (Api.Api.AndroidUserRegistration(reg) != null)
                    {
                        AlertDialog dialog = new AlertDialog.Builder(this).Create();
                        dialog.SetTitle("Uspesno ste kreirali nalog!");
                        dialog.SetMessage("Sada cete biti vraceni na stranicu za prijavljivanje.");
                        dialog.SetButton("U redu", OkDugme);
                        dialog.Show();
                    }
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                }
            }
            else
            {
                Toast.MakeText(this, "Proverite podatke jos jednom!", ToastLength.Short).Show();
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
            if (FindViewById<TextView>(Resource.Id.EditTextUsername).Text.Matches(string.Empty))
            {
                greska += "Unesite username!\n";
                validno = false;
            }

            //email
            string email = FindViewById<TextView>(Resource.Id.EditTextEmail).Text.Trim();
            string emailPatern = "[a-zA-Z0-9._-]+@[a-z]+\\.+[a-z]+";
            if (!email.Matches(emailPatern))
            {
                greska += "Email nije validan!\n";
                validno = false;
            }

            //passwordi
            string pass = FindViewById<TextView>(Resource.Id.EditTextPassword).Text;
            string passA = FindViewById<TextView>(Resource.Id.EditTextPasswordAgain).Text;
            if (!pass.Matches(passA))
            {
                greska += "Sifre nije ista!\n";
                validno = false;
            }

            //telefon
            if (FindViewById<TextView>(Resource.Id.EditTextPhone).Text.Matches(string.Empty))
            {
                greska += "Unesite telefon!\n";
                validno = false;
            }

            Toast.MakeText(this, greska, ToastLength.Long).Show();
            return validno;
        }
    }
}