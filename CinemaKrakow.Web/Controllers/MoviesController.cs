using CinemaKrakow.Data.Models;
using CinemaKrakow.Data.Services;
using System.Web.Mvc;

namespace CinemaKrakow.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieData db;

        public MoviesController(IMovieData db)
        {
            this.db = db;
        }

        // GET: movies
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("NotFound");
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            db.Add(movie);
            return RedirectToAction("Details", new { id = movie.Id });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            db.Edit(movie);
            TempData["Message"] = "You Have Edited the movie";
            return RedirectToAction("Details", new { id = movie.Id });
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);
            if (model == null)
            {
                return View("Not Found");
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection form)
        {
            db.Delete(id);
            return RedirectToAction("Index");
        }



    }
}
