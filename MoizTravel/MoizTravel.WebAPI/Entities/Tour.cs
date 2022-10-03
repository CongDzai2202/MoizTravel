using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class Tour
    {
        public int TourId { get; set; }
        public string TourName { get; set; }
        public string Address { get; set; }
        public string PlaceGo { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public Status Status { get; set; }
    }
}
