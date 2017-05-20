using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MensariumAPI.Podaci.Entiteti;


namespace MensariumAPI.Podaci.DTO
{
    public class PrivilegijeFullDto
    {
        public int IdPrivilegije { get; protected set; }
        public string Opis { get; set; }
    }
}