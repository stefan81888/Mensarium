using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MensariumAPI.Podaci.DTO
{
    public class ObrokUplataDto
    {
        public int IdKorisnika { get; set; }
        public int IdTipa { get; set; }
        public int BrojObroka { get; set; }
        public int IdLokacijeUplate { get; set; }
    }
}