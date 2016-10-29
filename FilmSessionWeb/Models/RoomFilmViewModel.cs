using System;
using System.Collections.Generic;

namespace FilmSessionWeb.Models
{
    public class RoomFilmViewModel
    {
        public int RoomFilmID { get; set; }
        public string RoomFilmPrefix { get; set; }
        public string RoomFilmCode { get; private set; }
        public string RoomFilmName { get; set; }
        public int RoomAmountSeat { get; set; }
        public string RoomFilmStatus { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public virtual ICollection<SeatTableViewModel> SeatTables { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}