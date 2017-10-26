using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace ASPNetWebTest.Models {
    [Table(name: "Page")]
    public class Page {
        public int PageID { get; set; }
        public string PageLink { get; set; }
        public string PageName { get; set; }
        public string PageHtml { get; set; }
    }

    public class PageContext : DbContext {
        public DbSet<Page> Pages { get; set; }
    }
}