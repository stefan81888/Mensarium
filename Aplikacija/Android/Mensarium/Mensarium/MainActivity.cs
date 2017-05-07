using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using Android.Content;

namespace Mensarium
{
    [Activity(Theme = "@android:style/Theme.DeviceDefault.NoActionBar", Label = "Mensarium", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        Button loginButton;
        Button createAccountButton;

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
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(MainSwipePage));

            StartActivity(intent);
        }

        private void CreateAccountButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(CreateAccPrviActivity));

            StartActivity(intent);
        }

    }
}

