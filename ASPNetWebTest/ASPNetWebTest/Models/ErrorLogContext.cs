using System.Data.Entity;

namespace ASPNetWebTest.Models {
    public class ErrorLogContext : DbContext {
        public DbSet<ErrorLog> errors { get; set; }
    }
}