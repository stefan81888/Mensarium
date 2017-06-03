using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    public class Student : User
    {
        public string Index { get; set; }
        public DateTime ValidUntil { get; set; }
        public Faculty Faculty { get; set; }
    }
}
