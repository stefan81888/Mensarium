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
    public class Poziv
    { 
        public bool status { set; get; }
        public int kolikoMinutaTraje { set; get; }
        public DateTime vremeKreiranja { set; get; }
        public DateTime vremePoziva { set; get; }
        //lista korisnika

        public Poziv()
        {
            
        }
    }
}