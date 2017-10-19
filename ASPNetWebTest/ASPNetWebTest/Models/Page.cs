using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetWebTest.Models {
    [Table(name: "Page")]
    public class Page {
        public int PageID { get; set; }
        public string PageLink { get; set; }
        public string PageName { get; set; }
    }
}