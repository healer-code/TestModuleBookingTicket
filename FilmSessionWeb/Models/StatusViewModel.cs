using System;
using System.Collections.Generic;

namespace FilmSessionWeb.Models
{
    public class StatusViewModel
    {
        public string StatusID { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<FilmViewModel> Films { get; set; }
        public virtual ICollection<FilmSessionViewModel> FilmSessions { get; set; }
        public virtual ICollection<SeatListViewModel> SeatLists { get; set; }
        public virtual ICollection<SeatTypeViewModel> SeatTypes { get; set; }
        public virtual ICollection<SeatTableViewModel> SeatTables { get; set; }
        public virtual ICollection<RoomFilmViewModel> RoomFilms { get; set; }
        public virtual ICollection<TimeSessionViewModel> TimeSessions { get; set; }
        public virtual ICollection<CinemaViewModel> Cinemas { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}