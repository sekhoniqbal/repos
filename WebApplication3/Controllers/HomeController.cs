using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Saved(FormCollection fc)
        {
            // below two lines can be used to get url paraments if request is get
            //and you dont want to pass values as arguments to actioncontroller.
           /* string Name = Request.QueryString["name"];
            string Age = Request.QueryString["age"];
            */  
            usersdbEntities1 db = new usersdbEntities1();
             user row = new user();
            row.name = fc["name"].ToString();
            row.age = fc["Age"].ToString();
            db.users.Add(row);
            db.SaveChanges();
        
            
            return Content("Data saved");
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
        public ActionResult Insert()
        {
            return Content("Inserted");
        }
    }
}