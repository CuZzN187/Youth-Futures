using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASPNetWebTest.Models {
    [Table(name: "User")]
    public class User {
        [Key]
        [Required]
        public int UserID { get; set; }

        [Required]
        public string UserAlias { get; set; }

        [Required]
        public bool UserRights { get; set; }

        [Required]
        public string UserPasswordHash { get; set; }
        
        [Required]
        public string UserFirstName { get; set; }

        [Required]
        public string UserLastName { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        public DateTime UserDateRequested { get; set; }

        public bool UserIsApproved { get; set; }
    }
}