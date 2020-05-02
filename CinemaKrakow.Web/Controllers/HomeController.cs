using CinemaKrakow.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaKrakow.Web.Controllers
{
    public class HomeController : Controller
    {
        IMovieData db;

        public HomeController(IMovieData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
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
    }
}