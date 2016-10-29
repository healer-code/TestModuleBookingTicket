using System;
using System.Collections.Generic;

namespace FilmSessionWeb.Models
{
    public class FilmViewModel
    {
        public int FilmID { get; set; }
        public string FilmPrefix { get; set; }
        public string FilmCode { get; private set; }
        public string FilmName { get; set; }
        public int FilmDuration { get; set; }
        public string FilmStatus { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public virtual ICollection<FilmSessionViewModel> FilmSessions { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}