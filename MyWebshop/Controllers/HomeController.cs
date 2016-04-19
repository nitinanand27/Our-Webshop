using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebshop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "MAN is all about being a Man";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakta Oss";

            return View();
        }
    }
}