using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ASPNetWebTest.Models {
    [Table(name: "User")]
    public class User {
        [Key]
        public int UserID { get; set; }

        public string UserAlias { get; set; }
        public bool UserRights { get; set; }
        public string UserPasswordHash { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public DateTime UserDateRequested { get; set; }
        public bool UserIsApproved { get; set; }
    }
}