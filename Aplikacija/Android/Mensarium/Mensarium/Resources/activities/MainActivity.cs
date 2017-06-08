using System;
using System.Threading;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content;
using Android.Views;
using Mensarium.Api;
using Mensarium.Comp.DTOs;
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
            //var txtView = FindViewById<TextView>(Resource.Id.naslov);
            //Typeface tf = Typeface.CreateFromAsset(Assets, "rage.ttf");
            //txtView.SetTypeface(tf, TypefaceStyle.Normal);

            this.loginButton = FindViewById<Button>(Resource.Id.signInDugme);
            this.loginButton.Click += LoginButton_Click;

            this.createAccountButton = FindViewById<Button>(Resource.Id.activateDugme);
            this.createAccountButton.Click += CreateAccountButton_Click;

            this.check = FindViewById<CheckBox>(Resource.Id.checkRemember);

            FindViewById<TextView>(Resource.Id.forgotPassword).Click += ForgotOnClick;

            ProbajDaUcitasKorisnika();
        }

        private void ForgotOnClick(object sender, EventArgs eventArgs)
        {
            /*
            var alert = new AlertDialog.Builder(this);
            alert.SetTitle("Oh ne!");
            alert.SetPositiveButton("U redu", (o, args) => { alert.Dispose(); });

            alert.SetMessage("Nista ne brinite!\n\nRadi resetovanja sifre, javite se nasem adminu na mail:\n\ndalibor.aleksic.dacha@gmail.com");

            alert.Show();
            */

            var inflater = LayoutInflater.From(this);
            var view = inflater.Inflate(Resource.Layout.forgotDialog, null);

            var dialogForgot = new AlertDialog.Builder(this);
            var dialogPin = new AlertDialog.Builder(this);
            var alertUspesno = new AlertDialog.Builder(this);

            var username = view.FindViewById<TextView>(Resource.Id.forgotUsername);
            string ime = "";

            dialogForgot.SetView(view);

            dialogForgot.SetPositiveButton("Resetuj", delegate(object o, DialogClickEventArgs args)
            {
                if (!username.Text.Equals(String.Empty))
                {
                    ime = username.Text;
                    try
                    {
                        //Api.Api.ZaboravljenaSifra(ime);
                        dialogForgot.Dispose();

                        var alert = new AlertDialog.Builder(this);
                        alert.SetTitle("Resetovanje!");
                        alert.SetMessage("Proverite Vas mail kako bi ste dobili PIN za reset.\n" +
                                         "Pin ukucajte na sledecoj formi.");
                        alert.SetPositiveButton("U redu", (ooo, argsss) =>
                        {
                            alert.Dispose();
                            dialogPin.Show();
                        });

                        alert.Show();
                    }
                    catch (Exception ex)
                    {
                        Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
                        dialogForgot.Dispose();
                    }
                }
                else
                {
                    Toast.MakeText(this, "Unesite korisnicko ime!", ToastLength.Short).Show();
                }
            });

            dialogForgot.SetNegativeButton("Unesi PIN", delegate(object o, DialogClickEventArgs args)
            {
                dialogForgot.Dispose();
                dialogPin.Show();
            });


            var view2 = inflater.Inflate(Resource.Layout.pinDialog, null);
            
            dialogPin.SetView(view2);

            dialogPin.SetPositiveButton("Potvrdi", delegate(object o, DialogClickEventArgs args)
            {
                var pin = view2.FindViewById<TextView>(Resource.Id.pin);
                var sifra = view2.FindViewById<TextView>(Resource.Id.pinNovaSifra);
                var sifraOpet = view2.FindViewById<TextView>(Resource.Id.pinNovaSifraOpet);

                if (sifra.Text.Equals(sifraOpet.Text) && !pin.Text.Equals(String.Empty))
                {
                    PassRecoveryDto noviPass = new PassRecoveryDto()
                    {
                        Pin = pin.Text,
                        KorisnickoIme = ime,
                        NovaSifra = sifra.Text
                    };

                    try
                    {
                       // Api.Api.OporavakSifre(noviPass);
                    }
                    catch (Exception ex)
                    {
                        Toast.MakeText(this, ex.Message, ToastLength.Long).Show();
                        dialogPin.Dispose();
                    }
                }
                else
                {
                    if(!pin.Text.Equals(String.Empty))
                    Toast.MakeText(this, "Unesite PIN!", ToastLength.Short).Show();
                    else
                    {
                        Toast.MakeText(this, "Sifre se ne poklapaju!", ToastLength.Short).Show();
                    }
                }
            });

            alertUspesno.SetTitle("Obavestenje!");
            alertUspesno.SetMessage("Uspesno ste resetovali Vasu sifru!");
            alertUspesno.SetPositiveButton("U redu", (o, args) => alertUspesno.Dispose());

            dialogForgot.Show();
        }

        private void ProbajDaUcitasKorisnika()
        {
            var prefs = Application.Context.GetSharedPreferences("Mensarium", FileCreationMode.Private);

            if(!prefs.GetString("username", String.Empty).Equals(String.Empty))
            {
                FindViewById<TextView>(Resource.Id.usernameText).Text = prefs.GetString("username", String.Empty);
                FindViewById<TextView>(Resource.Id.passwordText).Text = prefs.GetString("password", String.Empty);
            };
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
            alert.SetCancelable(false);

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
                    intent.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                    StartActivity(intent);

                    alert.Dismiss();

                    MSettings.CurrentSession.LoggedUser = MUtility.User_From_KorisnikFullDto(korisnik);

                    if (check.Checked)
                        ZapamtiKorisnika(clog.KIme_Mail, clog.Sifra);

                    this.Finish();
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
                RunOnUiThread(() => Toast.MakeText(this, "Nepravilno korisnicko ime ili lozinka!", ToastLength.Short).Show());
            }
        }
    }
}

