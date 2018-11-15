using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GuiaLocalApi.Models
{
    public class MiGuiaContext : DbContext
    {
        public MiGuiaContext() : base("MiGuiaConnection")
        {

        }
        public DbSet<Lugar> Lugares { get; set; }
    }
}