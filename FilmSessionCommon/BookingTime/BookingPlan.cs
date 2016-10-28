using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmSessionCommon.BookingTime
{
    public class BookingPlan
    {
        public DateTime DateCreatePlan { get; set; }
        public List<BookingDate> PlanCalendar { get; set; }
    }

}
