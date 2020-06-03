using CinemaKrakow.Data.Models;
using CinemaKrakow.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CinemaKrakow.Web.Controllers
{
    public class ModeratorController : Controller
    {
        
        private readonly IModeratorData db;

        public ModeratorController(IModeratorData db)
        {
            this.db = db;
        }

        // GET: Moderator
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(Moderator moderator)
        {
            var temp = db.GetByUserName(moderator.Username);
            if (temp == null)
                return View("NotFound");
            if (temp.Password==moderator.Password)
                    return Redirect("/Movies/Index");
            return View("NotFound");
        }

    }
}