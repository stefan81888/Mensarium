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

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "CreateAccPrviActivity")]
    public class CreateAccPrviActivity : Activity
    {

        Button nextButton;

        private TextView idText;
        private TextView passText;

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
            ClientZaRegistracijuDto reg = new ClientZaRegistracijuDto();;

            reg.DodeljeniId = Int32.Parse(idText.Text);
            reg.DodeljenaLozinka = passText.Text;

            try
            {
                if (Api.Api.AndroidUserRegistration(reg) != null)
                {
                    var intent = new Intent(this, typeof(CreateAccDrugiActivity));

                    intent.PutExtra("dodeljenID", reg.DodeljeniId);
                    intent.PutExtra("dodeljenaLozinka", reg.DodeljenaLozinka);

                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Podaci nisu dobri. Probajte ponovo!", ToastLength.Short).Show();
                }
            }
            catch (Exception ex)
            {
                Toast.MakeText(this, ex.Message, ToastLength.Short).Show();
            }

            
        }
    }
}