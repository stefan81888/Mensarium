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

namespace Mensarium.Comp.DTOs
{
    public class StudentAzuriranjeDto
    {
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string StaraSifra { get; set; }
        public string NovaSifra { get; set; }
    }
}