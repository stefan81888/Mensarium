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

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "CreateAccPrviActivity")]
    public class CreateAccPrviActivity : Activity
    {

        Button nextButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.createAccPrvi);

            this.nextButton = FindViewById<Button>(Resource.Id.nextDugme);
            this.nextButton.Click += NextButton_Click;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CreateAccDrugiActivity));

            StartActivity(intent);
        }
    }
}