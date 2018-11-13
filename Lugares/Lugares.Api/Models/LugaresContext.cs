using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lugares.Api.Models
{
    public class LugaresContext : DbContext
    {
        public LugaresContext() : base("LugaresConnection")
        {

        }

        public DbSet<Lugares> Lugares { get; set; }
    }
}