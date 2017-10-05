using System.Web.Mvc;
using log4net;

namespace ASPNetWebTest.Controllers {
    //controller files must end with 'Controller'
    public class HomeController : Controller {  
        //we will need an ActionResult for each page
        //function at the top goes first, regardless if INDEX exists

        private static log4net.ILog Log { get; set; }

        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        //will need to make a static log class

        public ActionResult Index() {

            log.Debug("Debug Message");
            log.Warn("Warn Message");
            log.Error("Error Message");
            log.Fatal("Fatal Message");
            return View();
        }

        public ActionResult IndexTest()
        {
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

        public ActionResult Login()
        {
            ViewBag.Message = "THIS IS THE LOG IN PAGE!";
            //add ur code
            return View();
        }
    }
}