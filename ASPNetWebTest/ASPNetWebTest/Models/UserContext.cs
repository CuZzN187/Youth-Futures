using System.Data.Entity;

namespace ASPNetWebTest.Models {
    public class UserContext : DbContext {
        public DbSet<User> user { get; set; }
    }
}