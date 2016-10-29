using System;

namespace FilmSessionWeb.Models
{
    public class FilmSessionViewModel
    {
        public int FilmID { get; set; }
        public int CinemaID { get; set; }
        public string FilmSessionStatus { get; set; }
        public string FilmCalendar { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public virtual FilmViewModel Film { get; set; }
        public virtual CinemaViewModel Cinema { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}