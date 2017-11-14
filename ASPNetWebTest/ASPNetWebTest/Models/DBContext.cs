using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ASPNetWebTest.Models
{
    public class DBContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<ErrorLog> errors { get; set; }
    }
}