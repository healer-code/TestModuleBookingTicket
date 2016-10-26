using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FilmSessionModel.Abstracts;

namespace FilmSessionModel.Models
{
    [Table("Films")]
    public class Film:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FilmID { get; set; }

        [Required]
        [DataType("nvarchar")]
        [MaxLength(3)]
        public string FilmPrefix { get; set; }

        [Required]
        [DataType("nvarchar")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string FilmCode
        {
            get
            {
                return FilmPrefix + FilmID.ToString();
            }
            private set
            {
            }
        }
        [Required]
        [DataType("nvarchar")]
        [MaxLength(100)]
        public string FilmName { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int FilmDuration { get; set; }

        [Required]
        public string FilmStatus { get; set; }

        [ForeignKey("FilmStatus")]
        public virtual Status Status { get; set; }
    }
}