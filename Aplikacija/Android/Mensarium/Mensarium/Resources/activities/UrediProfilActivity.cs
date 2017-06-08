using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using DE.Hdodenhof.Circleimageview;
using Mensarium.Comp;
using Mensarium.Comp.DTOs;
using Mensarium.Components;

namespace Mensarium.Resources.activities
{
    [Activity(Label = "Uredjivanje profila", Theme = "@style/Theme.AppCompat")]
    public class UrediProfilActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UrediProfil);

            FindViewById<Button>(Resource.Id.PromeniSifruDugme).Click += PromeniSifru;
            FindViewById<Button>(Resource.Id.PromeniMailDugme).Click += PromeniMail;
            FindViewById<Button>(Resource.Id.PromeniTelefonDugme).Click += PromeniTelefon;


            //popunjavanje labela
            User korisnik = MSettings.CurrentSession.LoggedUser;

            FindViewById<TextView>(Resource.Id.urediImeIPrezime).Text = korisnik.FirstName + " " + korisnik.LastName;
            FindViewById<TextView>(Resource.Id.urediUsername).Text = "@" + korisnik.Username;
            FindViewById<TextView>(Resource.Id.urediBrIdexa).Text = korisnik.BrojIdexa;
            FindViewById<TextView>(Resource.Id.urediMail).Text = korisnik.Email;
            FindViewById<TextView>(Resource.Id.urediBrojTelefona).Text = korisnik.PhoneNumber;

            FindViewById<CircleImageView>(Resource.Id.promeniSlika).SetImageBitmap(ImageManager.Get(this, korisnik.UserID));
        }

        private void PromeniTelefon(object sender, EventArgs eventArgs)
        {
            var inflater = LayoutInflater.From(this);

            var view = inflater.Inflate(Resource.Layout.PromeniMailTelefon, null);

            var dialog = new Android.Support.V7.App.AlertDialog.Builder(this);
            dialog.SetView(view);

            view.FindViewById<TextView>(Resource.Id.mailTelefonNaslov).Text = "Ukucajte novi broj telefona: ";

            var telefonText = view.FindViewById<EditText>(Resource.Id.promeniMailNoviMail);
            var sifraText = view.FindViewById<EditText>(Resource.Id.promeniPotvrdaSifre);

            //dialog vrsi se obradadada
            var dialogObrada = new Android.Support.V7.App.AlertDialog.Builder(this);
            dialogObrada.SetTitle("Vrsi se azuriranje telefona!");
            dialogObrada.SetMessage("Molimo sacekajte.");
            dialogObrada.SetCancelable(false);
            //

            dialog.SetPositiveButton("Promeni", delegate(object o, DialogClickEventArgs args)
            {
                if (telefonText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo ukucajte novi broj telefona.", ToastLength.Short);
                    dialog.Dispose();
                }

                if (sifraText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo potvrdite sifrom.", ToastLength.Short);
                    dialog.Dispose();
                }

                StudentAzuriranjeDto noviTelefon = new StudentAzuriranjeDto()
                {
                    Telefon = telefonText.Text,
                    StaraSifra = sifraText.Text
                };

                dialogObrada.Show();
                Api.Api.UpdateKorisnika(noviTelefon);
                dialogObrada.Dispose();

                Toast.MakeText(this, "Uspesno ste azurirali Vas broj telefona.", ToastLength.Long);
            });

            dialog.SetNegativeButton("Odustani", delegate(object o, DialogClickEventArgs args) { dialog.Dispose(); });

            dialog.Show();
        }

        private void PromeniMail(object sender, EventArgs eventArgs)
        {
            var inflater = LayoutInflater.From(this);

            var view = inflater.Inflate(Resource.Layout.PromeniMailTelefon, null);

            var dialog = new Android.Support.V7.App.AlertDialog.Builder(this);
            dialog.SetView(view);

            var mailText = view.FindViewById<EditText>(Resource.Id.promeniMailNoviMail);
            var sifraText = view.FindViewById<EditText>(Resource.Id.promeniPotvrdaSifre);

            //dialog vrsi se obradadada
            var dialogObrada = new Android.Support.V7.App.AlertDialog.Builder(this);
            dialogObrada.SetTitle("Vrsi se azuriranje telefona!");
            dialogObrada.SetMessage("Molimo sacekajte.");
            dialogObrada.SetCancelable(false);
            //

            dialog.SetPositiveButton("Promeni", delegate (object o, DialogClickEventArgs args)
            {
                if (mailText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo ukucajte novi mail.", ToastLength.Short);
                    dialog.Dispose();
                }

                if (sifraText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo potvrdite sifrom.", ToastLength.Short);
                    dialog.Dispose();
                }

                StudentAzuriranjeDto noviMail = new StudentAzuriranjeDto()
                {
                    Mail = mailText.Text,
                    StaraSifra = sifraText.Text
                };

                dialogObrada.Show();
                Api.Api.UpdateKorisnika(noviMail);
                dialogObrada.Dispose();

                Toast.MakeText(this, "Uspesno ste azurirali Vasu mail adresu.", ToastLength.Long);
            });

            dialog.SetNegativeButton("Odustani", delegate (object o, DialogClickEventArgs args) { dialog.Dispose(); });

            dialog.Show();
        }

        private void PromeniSifru(object sender, EventArgs eventArgs)
        {
            var inflater = LayoutInflater.From(this);

            var view = inflater.Inflate(Resource.Layout.PromeniSifruDialog, null);

            var dialog = new Android.Support.V7.App.AlertDialog.Builder(this);
            dialog.SetView(view);

            var sifraText = view.FindViewById<EditText>(Resource.Id.promeniNovaSifra);
            var opetSifraText = view.FindViewById<EditText>(Resource.Id.promeniNovaSifraOpet);
            var staraSifraText = view.FindViewById<EditText>(Resource.Id.promeniPotvrdaSifre);

            //dialog vrsi se obradadada
            var dialogObrada = new Android.Support.V7.App.AlertDialog.Builder(this);
            dialogObrada.SetTitle("Vrsi se azuriranje telefona!");
            dialogObrada.SetMessage("Molimo sacekajte.");
            dialogObrada.SetCancelable(false);
            //

            dialog.SetPositiveButton("Promeni", delegate (object o, DialogClickEventArgs args)
            {
                if (sifraText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo ukucajte novu sifru.", ToastLength.Short);
                    dialog.Dispose();
                }

                if (opetSifraText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo ukucajte novu sifru opet.", ToastLength.Short);
                    dialog.Dispose();
                }

                if (staraSifraText.Text.Equals(String.Empty))
                {
                    Toast.MakeText(this, "Molimo ukucajte staru sifru.", ToastLength.Short);
                    dialog.Dispose();
                }

                if (!sifraText.Text.Equals(opetSifraText.Text))
                {
                    Toast.MakeText(this, "Sifre nisu iste!", ToastLength.Short);
                    dialog.Dispose();
                }

                StudentAzuriranjeDto novaSifra = new StudentAzuriranjeDto()
                {
                    NovaSifra = sifraText.Text,
                    StaraSifra = staraSifraText.Text
                };

                dialogObrada.Show();
                Api.Api.UpdateKorisnika(novaSifra);
                dialogObrada.Dispose();

                Toast.MakeText(this, "Uspesno ste azurirali Vasu sifru.", ToastLength.Long);
            });

            dialog.SetNegativeButton("Odustani", delegate (object o, DialogClickEventArgs args) { dialog.Dispose(); });

            dialog.Show();
        }

    }
}