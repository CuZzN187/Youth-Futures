using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetWebTest.Models {
    [Table(name: "ErrorLog")]
    public class ErrorLog {
        [Key]
        [Required]
        public int ErrorID { get; set; }

        [Required]
        public string ErrorContent { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        //foreign key
        public int PageID { get; set; }

        //foreign key
        public int UserID { get; set; }
    }
}