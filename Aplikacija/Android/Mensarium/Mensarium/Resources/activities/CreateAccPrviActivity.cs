using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Provider;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MensariumDesktop.Model.Components.DTOs;
using RestSharp.Extensions;

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "CreateAccPrviActivity")]
    public class CreateAccPrviActivity : Activity
    {

        Button nextButton;

        private TextView idText;
        private TextView passText;

        private AlertDialog alert;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.createAccPrvi);

            this.nextButton = FindViewById<Button>(Resource.Id.nextDugme);
            this.nextButton.Click += NextButton_Click;

            idText = FindViewById<TextView>(Resource.Id.EditTextID);
            passText = FindViewById<TextView>(Resource.Id.EditTextAutoPassword);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                alert = new AlertDialog.Builder(this).Create();
                alert.SetTitle("Provera podataka");
                alert.SetMessage("Molimo sacekajte!");
                alert.Show();

                Thread novaNit = new Thread(pozoviApiFunkciju);
                novaNit.Start();
            }

        }

        private bool Validacija()
        {

            if (idText.Text.Equals(string.Empty) || passText.Text.Equals(string.Empty))
            {
                Toast.MakeText(this, "Popunite sva polja!", ToastLength.Short).Show();
                return false;
            }
            else
                return true;
        }

        private void pozoviApiFunkciju()
        {
            ClientZaRegistracijuDto reg = new ClientZaRegistracijuDto();

            reg.DodeljeniId = Int32.Parse(idText.Text);
            reg.DodeljenaLozinka = passText.Text;

            try
            {
                //Api.Api.AndroidUserRegistration(reg);
                Api.Api.AndroidPrvaPrijava(reg);

                var intent = new Intent(this, typeof(CreateAccDrugiActivity));

                intent.PutExtra("dodeljenID", reg.DodeljeniId);
                intent.PutExtra("dodeljenaLozinka", reg.DodeljenaLozinka);

                alert.Dismiss();

                StartActivity(intent);
            }
            catch (Exception ex)
            {
                alert.Dismiss();
                //Toast.MakeText(this, "Korisnik nije pronadjen u bazi!", ToastLength.Short).Show();
                RunOnUiThread(() => Toast.MakeText(this, "Korisnik nije pronadjen u bazi!", ToastLength.Short).Show());
            }
        }
    }
}