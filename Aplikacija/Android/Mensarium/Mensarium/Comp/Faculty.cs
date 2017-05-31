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
using Mensarium.Api;

namespace Mensarium.Components
{
    public class Faculty
    {
        public static List<Faculty> Faculties { get; protected set; }

        public static void UpdateFacultyList()
        {
            Faculties = MUtility.FacultyList_FromFakultetiFullDto(Api.Api.GetAllFaculties());
        }
        public int FacultyID { get; set; }
        public string Name { get; set; }
    }
}