using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string Discription { get; set; }
        public Status Status { get; set; }
        public TourDetail TourDetail { get; set; }
        public int TourDetailId { get; set; }
    }
}
