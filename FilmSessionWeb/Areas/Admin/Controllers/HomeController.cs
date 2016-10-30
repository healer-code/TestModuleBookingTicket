using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmSessionCommon.Common;

namespace FilmSessionWeb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult BookingDashboard()
        {
            var count = Session[CommonContrants.BOOKING_TICKET];
            return View();
        }
    }
}