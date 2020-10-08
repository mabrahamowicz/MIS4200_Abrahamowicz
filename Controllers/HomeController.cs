using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4200_Abrahamowicz.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Here is a little bit about me-";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here is my contact page.";

            return View();
        }
    }
}