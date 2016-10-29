using System;

namespace FilmSessionWeb.Models
{
    public class SeatListViewModel
    {
        public int SeatID { get; set; }
        public string SeatPrefix { get; set; }
        public string SeatCode { get; private set; }
        public int SeatListTable { get; set; }
        public int SeatTypeID { get; set; }
        public string SeatStatus { get; set; }
        public virtual SeatTypeViewModel SeatType { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public virtual SeatTableViewModel SeatTable { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}