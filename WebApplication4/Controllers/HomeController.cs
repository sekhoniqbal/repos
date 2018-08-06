using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        Model1Container db = new Model1Container();
        public ActionResult Index()
        {
            

            return View(db.Depts.ToList());
        }

        public ActionResult details(int did)
        {
            var d = db.Depts.Find(did);
            return View(d);
;        }
        [HttpGet]
        public ActionResult edit(int did) {
            var e = db.Depts.Find(did);
            return View(e);
        }
        [HttpPost]
        public ActionResult edit(WebApplication4.Dept e)
        {
            db.Entry(e).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return  RedirectToAction("Index") ;
        }
        [HttpGet]
        public ActionResult delete(int did)
        {
            var e = db.Depts.Find(did);
            return View(e);
        }
        [HttpPost]
        public ActionResult delete(WebApplication4.Dept e)
        {
            db.Entry(e).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult create()
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult create(WebApplication4.Dept e)
        {
            if (ModelState.IsValid) { 
            db.Entry(e).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
            }
            else { return View("create"); }
        }

    }
}