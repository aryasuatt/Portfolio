using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Active = 1;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Hakkımda";
            ViewBag.Active = 2;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "İletişim";
            ViewBag.Active = 6;

            return View();
        }

        public ActionResult Portfolio()
        {
            ViewBag.Title = "Portfolyo";
            ViewBag.Active = 5;

            return View();
        }

        //public ActionResult PortfolioDetais()
        //{
        //    ViewBag.Title = "Portfolyo Detay";
        //    ViewBag.Active = 5;

        //    return View();
        //}

        public ActionResult Resume()
        {
            ViewBag.Title = "Öz Geçmiş";
            ViewBag.Active = 3;

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Active = 4;

            return View();
        }

        public ActionResult StarterPage()
        {
            ViewBag.Title = "Home Page";
            ViewBag.Active = 1;

            return View();
        }
    }
}
