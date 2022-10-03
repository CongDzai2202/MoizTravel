using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class DataTour
    {
        public int DataTourId { get; set; }
        public string NumPersson1 { get; set; }
        public string NumPersson2 { get; set; }
        public string Data { get; set; }
        public string Note { get; set; }
        public double Paymcnt { get; set; }
        public Status Status { get; set; }
    }
}
