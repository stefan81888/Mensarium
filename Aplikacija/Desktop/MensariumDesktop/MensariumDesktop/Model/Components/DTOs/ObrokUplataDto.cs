using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumDesktop.Model.Components.DTOs
{
    public class ObrokUplataDto
    {
        public int IdKorisnika { get; set; }
        public int IdTipa { get; set; }
        public int BrojObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
    }
}