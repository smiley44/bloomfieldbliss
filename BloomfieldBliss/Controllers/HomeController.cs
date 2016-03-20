using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BloomfieldBliss.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reflexology()
        {
            ViewBag.Message = "Description of reflexology.";

            return View();
        }
        public ActionResult Treatment()
        {
            return View();
        }

        public ActionResult Benefits()
        {
            return View();
        }

        public ActionResult Prices()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";

            return View();
        }
        public ActionResult Location()
        {
            return View();
        }

    }
}