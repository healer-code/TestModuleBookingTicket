using System;
using System.Collections.Generic;

namespace FilmSessionWeb.Models
{
    public class SeatTypeViewModel
    {
        public int SeatTypeID { get; set; }
        public string SeatTypePrefix { get; set; }
        public string SeatTypeCode { get; private set; }
        public string SeatTypeName { get; set; }
        public string SeatTypeStatus { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public virtual ICollection<SeatListViewModel> SeatLists { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}