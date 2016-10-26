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

        public virtual IEnumerable<Film> Films { get; set; }
        public virtual IEnumerable<FilmSession> FilmSessions { get; set; }
    }
}