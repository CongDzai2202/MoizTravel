using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Entities
{
    public class AirlineTicketDetail
    {
        public int AirlineTicketDetailId { get; set; }
        public string AirlineTicketsName { get; set; }
        public double PriceTickets { get; set; }
    }
}
