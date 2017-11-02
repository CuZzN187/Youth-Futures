using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNetWebTest.Models {
    [Table(name: "Page")]
    public class Page {
        [Key]
        [Required]
        public int PageID { get; set; }

        [Required]
        public string PageLink { get; set; }

        [Required]
        public string PageName { get; set; }

        [Required]
        public string PageHtml { get; set; }
    }
}