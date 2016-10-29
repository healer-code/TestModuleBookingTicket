using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSessionService;
using AutoMapper;
using FilmSessionWeb.Models;

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
            var lstFilm = _filmService.GetAll();
            var lstFilmVm = Mapper.Map<IEnumerable<FilmViewModel>>(lstFilm);
            return View(lstFilmVm);
        }

        public ActionResult ViewFilmDetail(int filmID)
        {
            var detailFilm = _filmService.GetFilmWithSessionTime(filmID);
            ViewBag.BookingTime = _filmService.GenerateBookingPLan(detailFilm);
            detailFilm.FilmSessions = null;
            var result = Mapper.Map<FilmViewModel>(detailFilm);
            return View(result);
        }
    }
}