using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmSessionModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmSessionModel.Models
{
    [Table("Cinemas")]
    public class Cinema:Auditable
    {
        public Cinema()
        {
            FilmSessions = new HashSet<FilmSession>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CinemaID { get; set; }
        [Required]
        [DataType("nvarchar"),MaxLength(100)]
        public string CinemaName { get; set; }
        [Required]
        public string CinemaStatus { get; set; }
        [ForeignKey("CinemaStatus")]
        public virtual Status Status { get; set; }
        public virtual ICollection<FilmSession> FilmSessions { get; set; }
    }
}
