using System.Web.Mvc;

namespace ASPNetWebTest.Controllers {
    //controller files must end with 'Controller'
    public class HomeController : Controller {
        //we will need an ActionResult for each page
        //function at the top goes first, regardless if INDEX exists
        
        public ActionResult Index() {
            //this is a test from Robert
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Programs() {
            return View();
        }

        public ActionResult Involved() {
            return View();
        }

        public ActionResult Donate() {
            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";
            //add ur code
            return View();
        }

    }
}