using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MensariumDesktop.Model.Components
{
    public class Session
    {
        public User LoggedUser { get; set; }
        public String SessionID { get; set; }
    }
}
