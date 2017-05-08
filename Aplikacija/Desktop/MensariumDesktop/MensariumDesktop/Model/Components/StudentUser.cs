using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    public class StudentUser : User
    {
        public Faculty Faculty { get; set; }
    }
}
