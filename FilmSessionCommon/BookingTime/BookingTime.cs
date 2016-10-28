using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSessionCommon.BookingTime
{
    public class BookingTime
    {
        public int TimeBookingID { get; set; }
        public int TimeBookingSession { get; set; }
        public string TimeBookingDetail { get; set; }
        public int RoomFilmID { get; set; }
    }
}
