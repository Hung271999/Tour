using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tour.Models;

namespace Tour.Controllers
{
    public class TourController : Controller
    {
        TourDataContext data = new TourDataContext();
        // GET: Tour
        public ActionResult Index()
        {
            var tours = data.TOURs.ToList();
            return View(tours);
        }
        public ActionResult detailTour(string id)
        {
            if (id == null)
                return RedirectToAction("index", "Home");
            var tour = data.TOURs.Where(a => a.MATOUR == id).ToList();
            return View(tour.Single());
        }
    }
}