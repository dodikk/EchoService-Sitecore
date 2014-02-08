using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HWW2.Controllers
{
    public class EchoController : ApiController
    {
        public string Get()
        {
            return "value Hello world";
        }

    }
}
