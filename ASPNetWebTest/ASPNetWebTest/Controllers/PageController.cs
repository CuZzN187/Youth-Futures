using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNetWebTest.Models;

namespace ASPNetWebTest.Controllers
{
    public class PageController : Controller
    {
        PageDataContext pageContext = new PageDataContext();
        // GET: Page
        public ActionResult Index()
        {
            return View(pageContext.page.ToList());
        }
    }
}