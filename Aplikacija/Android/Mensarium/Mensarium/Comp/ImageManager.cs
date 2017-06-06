using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Mensarium.Comp
{
    public static class ImageManager
    {
        private static Dictionary<int, Bitmap> cache = new Dictionary<int, Bitmap>();

        public static Bitmap Get(Activity context, int idKorisnika)
        {
            if (!cache.ContainsKey(idKorisnika))
            {
                try
                {
                    Bitmap bitmap = Api.Api.GetUserImage(idKorisnika);

                    cache.Add(idKorisnika, bitmap);
                }
                catch (Exception ex)
                {
                    Toast.MakeText(context, ex.Message, ToastLength.Long).Show();
                }
            }

            return cache[idKorisnika];
        }
    }
}