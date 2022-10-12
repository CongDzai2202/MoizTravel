using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class TourDetail
    {
        public int TourDetailId { get; set; }
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public int TourGuiderId { get; set; }
        public TourGuider TourGuider { get; set; }
        public List<AirlineTicketDetail> AirlineTicketDetails { get; set; }
        public string TourDetailName { get; set; }
        public double TotalAmount { get; set; }
        public List<ImageTour> ImageTours { get; set; }
        public List<Place> Places { get; set; }
    }
}
