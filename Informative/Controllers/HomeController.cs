using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Informative.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ViewResult Service()
        {
            return View();
        }

        public ViewResult Support()
        {
            return View();
        }
    }
}