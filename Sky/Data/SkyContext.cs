using Sky.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sky.Data
{
    public class SkyContext : DbContext
    {
        public SkyContext() : base("name=skyConnection")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}