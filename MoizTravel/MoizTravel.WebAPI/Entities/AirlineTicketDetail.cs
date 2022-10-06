using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class AirlineTicketDetail
    {
        public int AirlineTicketDetailId { get; set; }
        public int AirlineTicketsId { get; set; }
        public AirlineTickets AirlineTickets { get; set; }
        public int TourDeltaiId { get; set; }
        public TourDetail TourDetail { get; set; }
        public int CustomerId { get; set; }
        public ImformationCustomer ImformationCustomer { get; set; }
        public string AirlineTicketsName { get; set; }
        public double PriceTickets { get; set; }
    }
}
