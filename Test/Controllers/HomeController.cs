using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewBag.time = DateTime.Now;
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult ajax()
        {
            ViewBag.time = DateTime.Now.ToString();
            return PartialView();
        }
    }
}