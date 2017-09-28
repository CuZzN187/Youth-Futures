using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ASPNetWebTest.Models {
    public class ErrorLog {
        [Key]
        public int id { get; set; }

        public string errorUserID { get; set; }
        public string errorMsg { get; set; }
        public string errorLoc { get; set; }
    }

    public class ErrorLogContext : DbContext {
        public DbSet<ErrorLog> errors { get; set; }
    }
}