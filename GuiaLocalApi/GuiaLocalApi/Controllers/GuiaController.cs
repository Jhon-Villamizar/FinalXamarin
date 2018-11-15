using GuiaLocalApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GuiaLocalApi.Controllers
{
    public class GuiaController : ApiController
    {
        [HttpGet]
        public IEnumerable<Lugar> Get()
        {
            using (var context = new MiGuiaContext())
            {
                return context.Lugares.ToList();
            }
        }
    }
}
