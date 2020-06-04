using CinemaKrakow.Data.Services;
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
            ViewBag.Message = "Description";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
        public ActionResult Detail(int id)
        {
            var movie = db.Get(id);
            return View(movie);
        }
    }
}