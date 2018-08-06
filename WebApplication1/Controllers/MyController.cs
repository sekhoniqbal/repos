using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index(string jatt)
        {
            return View();
        }

        public IActionResult formsubmit(int game, string name, string country)
        {
            return Content("following information about you have been saved<br>" +
                "Country:" +country+
                "Age:" + game+
                "Name:"+name);
        }
    }
}