using System.Data.Entity;

namespace ASPNetWebTest.Models {
    public class PageContext : DbContext {
        public DbSet<Page> Pages { get; set; }
    }
}