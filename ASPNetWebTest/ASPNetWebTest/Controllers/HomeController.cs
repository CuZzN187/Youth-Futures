using System.Web.Mvc;
using log4net;
using ASPNetWebTest.Models;
using System.Threading.Tasks;

namespace ASPNetWebTest.Controllers {
    //controller files must end with 'Controller'
    public class HomeController : Controller {  
        //we will need an ActionResult for each page
        //function at the top goes first, regardless if INDEX exists

        private static log4net.ILog Log { get; set; }

        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        private PageContext pageDB = new PageContext();

        //will need to make a static log class
        // GET: Index page
        public ActionResult Index() {
            ViewBag.HTMLContent = pageDB.Pages.Find(1).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Programs page
        public ActionResult Programs()
        {
            ViewBag.HTMLContent = pageDB.Pages.Find(2).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Involved, not pulling yet....... THIS WILL BE INDEX 6
        public ActionResult Involved()
        {
            return View();
        }
        // GET: About page
        public ActionResult About() {
            ViewBag.HTMLContent = pageDB.Pages.Find(3).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            ViewBag.HTMLContent = pageDB.Pages.Find(4).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Donate
        public ActionResult Donate()
        {
            ViewBag.HTMLContent = pageDB.Pages.Find(5).PageHtml;// Get page html from DB & and display
            return View();
        }
        // .......
        public ActionResult Login() {
            return View();
        }

        // POST: /
        [HttpPost, ValidateInput(false)]
        public ActionResult Index(string html)
        {
            pageDB.Pages.Find(1).PageHtml = html;
            pageDB.SaveChanges();
            ViewBag.HTMLContent = pageDB.Pages.Find(1).PageHtml;// Get page html from DB & and display
            return View();
        }
        // Post: Programs page
        [HttpPost, ValidateInput(false)]
        public ActionResult Programs(string html)
        {
            pageDB.Pages.Find(2).PageHtml = html;
            pageDB.SaveChanges();
            ViewBag.HTMLContent = pageDB.Pages.Find(2).PageHtml;// Get page html from DB & and display
            return View();
        }

        // Post: Involved, not pulling yet....... THIS WILL BE INDEX 6

        // Post: About page
        [HttpPost, ValidateInput(false)]
        public ActionResult About(string html)
        {
            pageDB.Pages.Find(3).PageHtml = html;
            pageDB.SaveChanges();
            ViewBag.HTMLContent = pageDB.Pages.Find(3).PageHtml;// Get page html from DB & and display
            return View();
        }

        // Post: Contact
        [HttpPost, ValidateInput(false)]
        public ActionResult Contact(string html)
        {
            pageDB.Pages.Find(4).PageHtml = html;
            pageDB.SaveChanges();
            ViewBag.HTMLContent = pageDB.Pages.Find(4).PageHtml;// Get page html from DB & and display
            return View();
        }

        // Post: Donate
        [HttpPost, ValidateInput(false)]
        public ActionResult Donate(string html)
        {
            pageDB.Pages.Find(5).PageHtml = html;
            pageDB.SaveChanges();
            ViewBag.HTMLContent = pageDB.Pages.Find(5).PageHtml;// Get page html from DB & and display
            return View();
        }
    }
}