using System;
using System.Collections.Generic;

namespace FilmSessionWeb.Models
{
    public class CinemaViewModel
    {
        public int CinemaID { get; set; }
        public string CinemaName { get; set; }
        public string CinemaStatus { get; set; }
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