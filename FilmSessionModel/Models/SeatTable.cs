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
    [Table("SeatTables")]
    public class SeatTable:Auditable
    {
        [Key]
        public int SeatTableID { get; set; }

        [Required,DataType("nvarchar")]
        public string SeatTableMap { get; set; }

        [Required]
        public int SeatTableRoom { get; set; }

        [Required]
        public int SeatTableWidth { get; set; }

        [Required]
        public int SeatTableHeight { get; set; }

        [Required]
        [DataType("nvarchar"), MaxLength(3)]
        public string SeatTableStatus { get; set; }

        [ForeignKey("SeatTableStatus")]
        public virtual Status Status { get; set; }

        [ForeignKey("SeatTableRoom")]
        public virtual RoomFilm RoomFilm { get; set; }
        public ICollection<SeatList> SeatLists { get; set; }
    }
}
