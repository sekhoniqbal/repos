using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_.netframework_;

namespace WebApplication_.netframework_.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string name, string country, string age)
        {

            usersdbEntities1 test = new usersdbEntities1();
            user obj = new user();
            obj.name = name;
            obj.country = country;
            obj.age = age;
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            
       
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}