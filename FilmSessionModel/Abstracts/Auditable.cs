using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmSessionModel.Abstracts
{
    public class Auditable : IAuditable
    {
        [Required,DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }
    }
}