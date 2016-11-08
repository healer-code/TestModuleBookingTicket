using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSessionCommon.Common;
using FilmSessionCommon.BookingTicket;
using FilmSessionService;
using AutoMapper;
using FilmSessionWeb.Models;
using System.Threading;

namespace FilmSessionWeb.Controllers
{
    public class BookingTicketController : Controller
    {
        private IRoomFilmService _roomFilmService;
        public BookingTicketController(IRoomFilmService roomFilmService)
        {
            _roomFilmService = roomFilmService;
        }

        ////GET: BookingTicket
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost]
        public JsonResult Booking(int timeBooking, int roomBooking,int ticketAmount)
        {
            BookingTicketModel model = new BookingTicketModel();
            model.TimeSessionID = timeBooking;
            model.RoomID = roomBooking;
            Session.Add(CommonContrants.BOOKING_TICKET, model);
            bool status = true;
            var roomResult = _roomFilmService.GetSingleById(model.RoomID);
            Thread.Sleep(3000);
            if (roomResult == null)
            {
                status = false;
                return Json(new
                {
                    status = status,           
                }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var roomVm = Mapper.Map<RoomFilmViewModel>(roomResult);
                TempData["RoomUser"] = roomVm;
                return Json(new
                {
                    status = status,
                    room = roomVm,
                }, JsonRequestBehavior.AllowGet);
            }                   
        }

        public ActionResult DetailBooking(int TimeSession)
        {
            var roomResult = TempData["RoomUser"];
            return View(roomResult);
        }
    }
}