using System;
using System.Collections.Generic;

namespace FilmSessionWeb.Models
{
    public class SeatTableViewModel
    {
        public int SeatTableID { get; set; }
        public string SeatTableMap { get; set; }
        public int SeatTableRoom { get; set; }
        public int SeatTableWidth { get; set; }
        public int SeatTableHeight { get; set; }
        public string SeatTableStatus { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public virtual RoomFilmViewModel RoomFilm { get; set; }
        public ICollection<SeatListViewModel> SeatLists { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
    }
}