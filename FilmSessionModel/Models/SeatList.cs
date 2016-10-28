using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilmSessionModel.Abstracts;

namespace FilmSessionModel.Models
{
    [Table("SeatLists")]
    public class SeatList:Auditable
    {
        [Key]
        public int SeatID { get; set; }
        [Required]
        [DataType("nvarchar")]
        [MaxLength(3)]
        public string SeatPrefix { get; set; }

        [DataType("nvarchar")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string SeatCode { get; private set; } 

        [Required]
        public int SeatListTable { get; set; }

        [Required]
        public int SeatTypeID { get; set; }
        [Required]
        [DataType("nvarchar"), MaxLength(3)]
        public string SeatStatus { get; set; }

        [ForeignKey("SeatTypeID")]
        public virtual SeatType SeatType { get; set; }
        [ForeignKey("SeatStatus")]
        public virtual Status Status { get; set; }

        [ForeignKey("SeatListTable")]
        public virtual SeatTable SeatTable { get; set; }
    }
}
