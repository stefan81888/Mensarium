using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;

namespace MensariumAPI.Podaci.DTO
{
    public class FakultetFullDto
    {
        public string Naziv { get; set; }
        public int IdFakultet { get; protected set; }
    }
}