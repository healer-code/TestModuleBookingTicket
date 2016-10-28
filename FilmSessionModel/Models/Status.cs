using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilmSessionModel.Abstracts;

namespace FilmSessionModel.Models
{
    [Table("Statuss")]
    public class Status:Auditable
    {
        [Key]
        [DataType("nvarchar")]
        [MaxLength(3)]
        public string StatusID { get; set; }

        [DataType("nvarchar")]
        [MaxLength(100)]
        public string StatusName { get; set; }

        public virtual ICollection<Film> Films { get; set; }
        public virtual ICollection<FilmSession> FilmSessions { get; set; }
        public virtual ICollection<SeatList> SeatLists { get; set; }
        public virtual ICollection<SeatType> SeatTypes { get; set; }
        public virtual ICollection<SeatTable> SeatTables { get; set; }
        public virtual ICollection<RoomFilm> RoomFilms { get; set; }
        public virtual ICollection<TimeSession> TimeSessions { get; set; }
        public virtual ICollection<Cinema> Cinemas { get; set; }
    }
}