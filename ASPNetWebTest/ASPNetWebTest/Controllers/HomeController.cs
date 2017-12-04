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

        //ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        private DBContext dataBase = new DBContext();

        private static User currentUser = null;

        private bool signedIn = false;

        private string editButtonElement = @"<button id =""editBtnEdit"" onclick=""myFunction();"" type=""button"">Edit Document</button>";
        private string loginElement = @"<a onclick=""document.getElementById('id01').style.display = 'block'"">Login</a>";
        private string logoutElement = @"<a onclick=""logout()"">Logout</a>";

        //will need to make a static log class
        // GET: Index page
        public ActionResult Index() {
            //dataBase.Pages.Find(1).PageHtml = @"";
            //dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(1).PageHtml;// Get page html from DB & and display
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }
        // GET: Programs page
        public ActionResult Programs()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(2).PageHtml;// Get page html from DB & and display
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }
        // GET: Involved, not pulling yet....... THIS WILL BE INDEX 6
        public ActionResult Involved()
        {
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }
        // GET: About page
        public ActionResult About() {
            ViewBag.HTMLContent = dataBase.Pages.Find(3).PageHtml;// Get page html from DB & and display
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(4).PageHtml;// Get page html from DB & and display
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }
        // GET: Donate
        public ActionResult Donate()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(5).PageHtml;// Get page html from DB & and display
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }

        // GET: ComingSoon
        public ViewResult ComingSoon()
        {
            checkAndDisplayButton();
            checkAndDisplayLoginOrLogout();
            return View("ComingSoon");
        }

        // GET: YouthStores
        public ViewResult YouthStories()
        {
            ViewBag.HTMLContent = dataBase.Pages.Find(6).PageHtml;// Get page html from DB & and display
            checkAndDisplayLoginOrLogout();
            checkAndDisplayButton();
            return View();
        }
        // Post: YouthStories page
        [HttpPost, ValidateInput(false)]
        public ActionResult YouthStories(string html)
        {
            dataBase.Pages.Find(6).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(6).PageHtml;// Get page html from DB & and display
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
                string pass = "pass";
                ViewBag.logIn = "pass";
                currentUser = dataBase.user.Find(1);
                return this.Json(pass);
            }
            else
            {
                //invalid creds
                string fail = "fail";
                ViewBag.logIn = "fail";
                return this.Json(fail);
            }
            
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult Logout(string username, string password)
        {
            currentUser = null;
            return this.Json("pass");
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

        // Post: ComingSoon
        /*[HttpPost, ValidateInput(false)]
        public ActionResult ComingSoon(string html)
        {
            dataBase.Pages.Find(6).PageHtml = html;
            dataBase.SaveChanges();
            ViewBag.HTMLContent = dataBase.Pages.Find(6).PageHtml;// Get page html from DB & and display
            return View();
        }
        */
        public ActionResult HandleError()
        {
            return View();
        }

        public void checkAndDisplayButton()
        {
            if(currentUser == null)
            {
                ViewData["BaldHeadButton"] = "";
            }
            else
            {
                ViewData["BaldHeadButton"] = editButtonElement;
            }
        }

        public void checkAndDisplayLoginOrLogout()
        {
            if (currentUser == null)
            {
                ViewData["LoginOrLogout"] = loginElement;
            }
            else
            {
                ViewData["LoginOrLogout"] = logoutElement;
            }
        }

    }
}