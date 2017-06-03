using System;
using System.Threading;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content;
using Mensarium.Api;
using Mensarium.Components;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp;

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "Mensarium", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button loginButton;
        Button createAccountButton;
        private AlertDialog alert;
        private CheckBox check;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.login);

            //font za naslov
            var txtView = FindViewById<TextView>(Resource.Id.naslov);
            Typeface tf = Typeface.CreateFromAsset(Assets, "rage.ttf");
            txtView.SetTypeface(tf, TypefaceStyle.Normal);

            this.loginButton = FindViewById<Button>(Resource.Id.signInDugme);
            this.loginButton.Click += LoginButton_Click;

            this.createAccountButton = FindViewById<Button>(Resource.Id.activateDugme);
            this.createAccountButton.Click += CreateAccountButton_Click;

            this.check = FindViewById<CheckBox>(Resource.Id.checkRemember);
        }

        private void ZapamtiKorisnika(string user, string pass)
        {
            var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);
            var prefEditor = prefs.Edit();

            prefEditor.PutString("username", user);
            prefEditor.PutString("password", pass);

            prefEditor.Commit();
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {

            alert = new AlertDialog.Builder(this).Create();
            alert.SetTitle("Ucitavanje");
            alert.SetMessage("Molimo sacekajte!");

            alert.Show();

            Thread novaNit = new Thread(PozoviApiFunkciju);
            novaNit.Start();

            /*
            var intent = new Intent(this, typeof(MainSwipePage));
            StartActivity(intent);
            */
        }

        private void CreateAccountButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CreateAccPrviActivity));
            StartActivity(intent);
        }

        private void PozoviApiFunkciju()
        {
            ClientLoginDto clog = new ClientLoginDto
            {
                KIme_Mail = FindViewById<TextView>(Resource.Id.usernameText).Text,
                Sifra = FindViewById<TextView>(Resource.Id.passwordText).Text
            };

            try
            {

                SesijaDto sesija = Api.Api.LoginUser(clog);
                MSettings.CurrentSession = new Session() { SessionID = sesija.IdSesije };

                KorisnikFullDto korisnik = Api.Api.GetUserFullInfo(sesija.IdKorisnika);
                if (korisnik.IdTipaNaloga == (int)User.UserAccountType.Student)
                {
                    //if (!Api.LogoutUser(MSettings.CurrentSession.SessionID))
                    //    throw new Exception("Neuspesno ciscenje logovanja");
                    var intent = new Intent(this, typeof(MainSwipePage));
                    StartActivity(intent);

                    alert.Dismiss();

                    MSettings.CurrentSession.LoggedUser = MUtility.User_From_KorisnikFullDto(korisnik);

                    if (check.Checked)
                        ZapamtiKorisnika(clog.KIme_Mail, clog.Sifra);
                }
                else
                {
                    alert.Dismiss();
                    MSettings.CurrentSession = null;
                    //Toast.MakeText(this, "Ovo nije korisnicki nalog!", ToastLength.Short).Show();
                    RunOnUiThread(() => Toast.MakeText(this, "Ovo nije korisnicki nalog!", ToastLength.Short).Show());
                }
            }
            catch (Exception ex)
            {
                alert.Dismiss();
                MSettings.CurrentSession = null;
                //Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
                RunOnUiThread(() => Toast.MakeText(this, ex.Message, ToastLength.Short).Show());
            }
        }
    }
}

