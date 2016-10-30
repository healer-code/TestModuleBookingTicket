using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSessionCommon.Common;
using FilmSessionCommon.BookingTicket;
using FilmSessionService;

namespace FilmSessionWeb.Controllers
{
    public class BookingTicketController : Controller
    {

        ////GET: BookingTicket
        //public ActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost]
        public JsonResult Booking(int timeBooking, int roomBooking)
        {
            BookingTicketModel model = new BookingTicketModel();
            model.TimeSessionID = timeBooking;
            model.RoomID = roomBooking;
            Session.Add(CommonContrants.BOOKING_TICKET, model);
            
        }
    }
}