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

namespace MensariumDesktop.Model.Components.DTOs
{
    public class PassRecoveryDto
    {
        public string Pin { get; set; }
        public string NovaSifra { get; set; }
        public string KorisnickoIme { get; set; }
    }
}