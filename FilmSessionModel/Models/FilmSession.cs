using FilmSessionModel.Abstracts;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmSessionModel.Models
{
    public class FilmSession : Auditable
    {
        [Key]
        public int FilmID { get; set; }

        [Required]
        [DataType("nvarchar")]
        public string FilmSessionStatus { get; set; }

        [Required]
        public string FilmCalendar { get; set; }

        [ForeignKey("FilmSessionStatus")]
        public virtual Status Status { get; set; }
    }
}