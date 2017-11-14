using System;
using System.Web.Mvc;
using System.Globalization;
using log4net;
using ASPNetWebTest.Models;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ASPNetWebTest.Controllers {
    //controller files must end with 'Controller'
    public class HomeController : Controller {  
        //we will need an ActionResult for each page
        //function at the top goes first, regardless if INDEX exists

        private static log4net.ILog Log { get; set; }

        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        private DBContext dataBase = new DBContext();

        //will need to make a static log class
        // GET: Index page
        public ActionResult Index() {
            ViewBag.HTMLContent = dataBase.Pages.Find(1).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Programs page
        public ActionResult Programs()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(2).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Involved, not pulling yet....... THIS WILL BE INDEX 6
        public ActionResult Involved()
        {
            return View();
        }
        // GET: About page
        public ActionResult About() {
            ViewBag.HTMLContent = dataBase.Pages.Find(3).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(4).PageHtml;// Get page html from DB & and display
            return View();
        }
        // GET: Donate
        public ActionResult Donate()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(5).PageHtml;// Get page html from DB & and display
            return View();
        }
        
        [HttpPost, ValidateInput(false)]
        public ActionResult Login(string username, string password) {
            //admin username and password
            string uname = dataBase.user.Find(1).UserAlias;
            string psw = dataBase.user.Find(1).UserPasswordHash;

            if(uname.Equals(username) && psw.Equals(password))
            {
                //if log in passes
            }
            else
            {
                //invalid creds
            }
            return View();
            }

        // POST: /
        [HttpPost, ValidateInput(false)]
        public ActionResult Index(string html)
        {
            dataBase.Pages.Find(1).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(1).PageHtml;// Get page html from DB & and display
            return View();
        }
        // Post: Programs page
        [HttpPost, ValidateInput(false)]
        public ActionResult Programs(string html)
        {
            dataBase.Pages.Find(2).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(2).PageHtml;// Get page html from DB & and display
            return View();
        }

        // Post: Involved, not pulling yet....... THIS WILL BE INDEX 6

        // Post: About page
        [HttpPost, ValidateInput(false)]
        public ActionResult About(string html)
        {
            dataBase.Pages.Find(3).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(3).PageHtml;// Get page html from DB & and display
            return View();
        }

        // Post: Contact
        [HttpPost, ValidateInput(false)]
        public ActionResult Contact(string html)
        {
            dataBase.Pages.Find(4).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(4).PageHtml;// Get page html from DB & and display
            return View();
        }

        // Post: Donate
        [HttpPost, ValidateInput(false)]
        public ActionResult Donate(string html)
        {
            dataBase.Pages.Find(5).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(5).PageHtml;// Get page html from DB & and display
            return View();
        }
    }
}