using FilmSessionModel.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace FilmSessionModel.Models
{
    [Table("TimeSessions")]
    public class TimeSession : Auditable
    {
        [Key]
        public int TimeSessionID { get; set; }

        [Required]
        public TimeSpan StartTime { get; set; }

        [Required]
        [DataType("nvarchar"), MaxLength(3)]
        public string TimeSessionStatus { get; set; }

        [ForeignKey("TimeSessionStatus")]
        public virtual Status Status { get; set; }
    }
}