using FilmSessionModel.Abstracts;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmSessionModel.Models
{
    [Table("SeatTypes")]
    public class SeatType : Auditable
    {
        [Key]
        public int SeatTypeID { get; set; }

        [Required]
        [DataType("nvarchar")]
        [MaxLength(3)]
        public string SeatTypePrefix { get; set; }

        [Required]
        [DataType("nvarchar")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string SeatTypeCode { get; private set; }

        [Required]
        [DataType("nvarchar"), MaxLength(100)]
        public string SeatTypeName { get; set; }

        [Required]
        [DataType("nvarchar"), MaxLength(3)]
        public string SeatTypeStatus { get; set; }

        [ForeignKey("SeatTypeStatus")]
        public virtual Status Status { get; set; }
        public virtual IEnumerable<SeatList> SeatLists { get; set; }
    }
}