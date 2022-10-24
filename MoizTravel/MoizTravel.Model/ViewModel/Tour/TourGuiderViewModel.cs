using System;

namespace MoizTravel.Model.ViewModel.Tour
{
    public class TourGuiderViewModel
    {
        public int TourGuiderId { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
    }
}
