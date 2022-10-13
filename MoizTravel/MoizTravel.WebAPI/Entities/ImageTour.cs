using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class ImageTour
    {
        public int ImageTourID { get; set; }
        public string DateCreate { get; set; }
        public string Url { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public TourDetail TourDetail { get; set; }
        public int TourDetailId { get; set; }
    }
}
