using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSessionService;

namespace FilmSessionWeb.Controllers
{
    public class HomeController : Controller
    {
        IFilmService _filmService;
        public HomeController(IFilmService filmService)
        {
            _filmService = filmService;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}