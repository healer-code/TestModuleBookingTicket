using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using FilmSessionModel.Abstracts;

namespace FilmSessionModel.Models
{
    public class BookingTicket:Auditable
    {
        public int BookingID { get; set; }
        public string BookingPrefix { get; set; }
        
    }
}
