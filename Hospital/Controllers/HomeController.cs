using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTermProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Home()
        {
            return View("Home", "~/Views/Shared/_Layout.cshtml");
        }

        public ActionResult About()
        {
            return View("About", "~/Views/Shared/_Layout.cshtml");
        }
        
        public ActionResult Doctors()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("Contact", "~/Views/Shared/_Layout.cshtml");
        }
    }
}