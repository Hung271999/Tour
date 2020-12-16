using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.Models;

namespace Tour.Controllers
{
    public class HomeController : Controller
    {
        TourDataContext data = new TourDataContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Place()
        {
            var place = data.DIEMTHAMQUANs.ToList();
            return View(place);
        }
        public ActionResult Tour()
        {
            var tours = data.TOURs.ToList();
            return View(tours);
        }

    }
}