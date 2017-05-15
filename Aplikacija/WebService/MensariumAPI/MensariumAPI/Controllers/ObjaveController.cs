using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MensariumAPI.Podaci.DTO;

namespace MensariumAPI.Controllers
{
    public class ObjaveController : ApiController
    {
        [HttpGet]
        public ObjavaDto PrikaziSveObjave()
        {
            return null;
        }
    }
}
