using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionModel.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmSessionModel.Models
{
    [Table("RoomFilms")]
    public class RoomFilm: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomFilmID { get; set; }

        [Required]
        [DataType("nvarchar")]
        [MaxLength(3)]
        public string RoomFilmPrefix { get; set; }

        [DataType("nvarchar")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string RoomFilmCode { get; private set; }

        [Required]
        public string RoomFilmName { get; set; }

        [Required]
        [Range(0,500)]
        public int RoomAmountSeat { get; set; }

        [Required]
        [DataType("nvarchar"), MaxLength(3)]
        public string RoomFilmStatus { get; set; }

        [ForeignKey("RoomFilmStatus")]
        public virtual Status Status { get; set; }
        public virtual ICollection<SeatTable> SeatTables { get; set; }
    }
}
