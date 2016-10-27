using FilmSessionModel.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmSessionModel.Models
{
    [Table("FilmSessions")]
    public class FilmSession : Auditable
    {
        [Key]
        [Column(Order = 0)]
        public int FilmSessionID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int CinemaID { get; set; }
        [Required]
        [DataType("nvarchar"), MaxLength(3)]
        public string FilmSessionStatus { get; set; }
        [Required]
        public string FilmCalendar { get; set; }
        [ForeignKey("FilmSessionStatus")]
        public virtual Status Status { get; set; }
        [ForeignKey("FilmSessionID")]
        public virtual Film Film { get; set; }
        [ForeignKey("CinemaID")]
        public virtual Cinema Cinema { get; set; }
    }
}