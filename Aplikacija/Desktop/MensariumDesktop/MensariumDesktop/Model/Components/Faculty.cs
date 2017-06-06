using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MensariumDesktop.Model.Controllers;

namespace MensariumDesktop.Model.Components
{
    public class Faculty
    {
        public static List<Faculty> Faculties { get; protected set; }

        public static void UpdateFacultyList()
        {
            Faculties = MUtility.FacultyList_FromFakultetiFullDto(Api.GetAllFaculties());
            Faculties.Sort((x,y) => x.FacultyID.CompareTo(y.FacultyID));
        }
        public int FacultyID { get; set; }
        public string Name { get; set; }
    }
}
