using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult find(FormCollection fc)
        {

            if (fc["id"] != null)
            {
                int id = int.Parse(fc["id"]);
               // usersdbEntities1 db = new usersdbEntities1();
                //ViewData["test"] = db.users.Where(row => row.id == id).First();
                
            }
            usersdbEntities1 db = new usersdbEntities1();
            var iqbal = db.users.First();
            return View(iqbal);
        }
    }
}