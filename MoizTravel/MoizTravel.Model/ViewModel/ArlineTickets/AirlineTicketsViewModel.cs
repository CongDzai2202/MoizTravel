using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoizTravel.Model.ViewModel
{
    public class AirlineTicketsViewModel
    {
        public int AirlineTicketsId { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public string FullName { get; set; }
        public DateTime DepartureTime { get; set; }
        public string NumberSeat { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DateStart { get; set; }
        public int Status { get; set; }
    }
}
