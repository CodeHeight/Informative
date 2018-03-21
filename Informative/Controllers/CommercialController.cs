using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Informative.Controllers
{
    public class CommercialController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Down", "Home");
        }

        public ActionResult RollingService()
        {
            return RedirectToAction("Down", "Home");
        }

        public ActionResult InsulatedSectional()
        {
            return RedirectToAction("Down", "Home");
        }
    }
}