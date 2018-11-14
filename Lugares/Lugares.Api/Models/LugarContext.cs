using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lugares.Api.Models
{
    public class LugarContext : DbContext
    {
        public LugarContext() : base("LugaresConnection")
        {

        }

        public DbSet<Lugar> Lugares { get; set; }
    }
}