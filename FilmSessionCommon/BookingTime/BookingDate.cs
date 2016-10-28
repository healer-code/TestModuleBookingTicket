using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSessionCommon.BookingTime
{
    public class BookingDate
    {
        public DateTime DateBooking { get; set; }
        public List<BookingTime> BookingTicketCalendar { get; set; }
    }
}
