using Lugares.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lugares.Api.Controllers
{
    public class LugaresController : ApiController
    {
        public IEnumerable<Lugares> Get()
        {
            using (LugaresContext context = new LugaresContext());
        }
    }
}
