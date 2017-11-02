using System.Data.Entity;

namespace ASPNetWebTest.Models {
    public class UserDataContext : DbContext {
        public DbSet<User> user { get; set; }
    }
}