using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PsypherComputing.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";

            return View();
        }

        public ActionResult Information()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }
    }

}