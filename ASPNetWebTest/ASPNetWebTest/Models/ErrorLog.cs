using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ASPNetWebTest.Models {
    public class ErrorLog {
        [Key]
        public int ErrorID { get; set; }

        public string ErrorContent { get; set; }
        public DateTime TimeStamp { get; set; }

        //foreign key
        public int PageID { get; set; }

        //foreign key
        public int UserID { get; set; }
    }

    public class ErrorLogContext : DbContext {
        public DbSet<ErrorLog> errors { get; set; }
    }
}