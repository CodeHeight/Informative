using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Informative.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Down", "Home");
        }

        public ActionResult Contact()
        {
            return RedirectToAction("Down", "Home");
        }

        public ActionResult Service()
        {
            return RedirectToAction("Down", "Home");
        }

        public ActionResult Support()
        {
            return RedirectToAction("Down", "Home");
        }

        public ActionResult Down()
        {
            return View();
        }
    }
}