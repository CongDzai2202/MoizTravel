using MoizTravel.WebAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class AirlineTickets
    {
        public int AirlineTicketsId { get; set; }
        public string StartLocation { get; set; }
        public string EndLocation { get; set; }
        public string FullName { get; set; }
        public DateTime DepartureTime { get; set; }
        public string NumberSeat { get; set; }
        public string FlightNumber { get; set; }
        public DateTime DateStart { get; set; }
        public Status Status { get; set; }
        public List<AirlineTicketDetail> AirlineTicketDetails { get; set; }

    }
}
