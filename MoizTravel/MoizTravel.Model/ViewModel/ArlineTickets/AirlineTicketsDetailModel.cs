using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoizTravel.Model.ViewModel.ArlineTickets
{
    public class AirlineTicketsDetailModel
    {
        public int Id { get; set; }
        public int CustomerID { get; set; }
        public int TourDetailID { get; set; }
        public int AirlineTicketsID { get; set; }
        public string AirlineTicketsName { get; set; }
        public long PriceTickets { get; set; }
    }
}
