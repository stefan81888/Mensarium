using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class TipObrokaDto
    {
        public int IdTipObroka { get; protected set; }
        public string Naziv { get; set; }

    }
}