using Lugares.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lugares.Api.Controllers
{
    public class LugarController : ApiController
    {
        [HttpGet]
        public IEnumerable<Lugar> Get()
        {
            using (LugarContext context = new LugarContext())
            {
                return context.Lugares.ToList();
            }
        }
    }
}
