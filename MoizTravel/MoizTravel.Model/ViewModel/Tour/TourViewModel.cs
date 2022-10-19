using System;

namespace MoizTravel.Model.ViewModel.Tour
{
    public class TourViewModel
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Address { get; set; }
        public string PlaceGo { get; set; }
        public double Price { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public int Status { get; set; }
    }
}
