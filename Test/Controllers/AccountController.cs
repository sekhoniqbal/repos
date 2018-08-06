using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Test.Models;

namespace Test.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(User a)
        {
            CollegeEntities db = new CollegeEntities();
            var count = db.Users.Where(u => u.Username == a.Username && u.Password == a.Password).Count();
            if (count == 0)
            {
                ViewBag.Msg = "Username or password is incorrect";
                return View();
            }
            else
            {
                FormsAuthentication.SetAuthCookie(a.Username, false);
                return RedirectToAction("index", "Home");
            }

            
        }
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            TempData["Msg"] = "You have been logged out successfully";
            return RedirectToAction("index", "home");
        }
        [AllowAnonymous]
        public ActionResult create()
        {
            CollegeEntities db = new CollegeEntities();
            User a = new User() { Username = "iqbal", Password = "singh", GroupName = "admin" };
            db.Users.Add(a);
            db.SaveChanges();
            return Content("success");
        }

    }
}