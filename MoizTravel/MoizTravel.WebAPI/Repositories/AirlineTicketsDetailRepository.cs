using MoizTravel.Model.ViewModel.ArlineTickets;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Repositories
{
    public class AirlineTicketsDetailRepository : IAirlineTicketsDetailRepository
    {
        private readonly MoizTravelDbContext _context;
        public AirlineTicketsDetailRepository(MoizTravelDbContext moizTravelDb)
        {
            _context = moizTravelDb;
        }

        public bool Create(AirlineTicketsDetailModel model)
        {
            if (model == null) return false;
            _context.airlineTicketDetails.Add(new AirlineTicketDetail()
            {
                CustomerId = model.CustomerID,
                AirlineTicketsName = model.AirlineTicketsName,
                AirlineTicketDetailId = model.AirlineTicketsID,
                PriceTickets = model.PriceTickets,
                TourDeltaiId = model.TourDetailID,
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            AirlineTicketDetail airlineTickets = _context.airlineTicketDetails.FirstOrDefault(c => c.AirlineTicketsId == id);
            airlineTickets.Status = 1;
            _context.airlineTicketDetails.Update(airlineTickets);
            _context.SaveChanges();
            return true;
        }

        public List<AirlineTicketsDetailModel> GetList()
        {
            return _context.airlineTicketDetails.ToList().Select(c=> new AirlineTicketsDetailModel() { 
            Id = c.AirlineTicketDetailId,
            CustomerID = c.CustomerId,
            AirlineTicketsID = c.AirlineTicketsId,
            AirlineTicketsName = c.AirlineTicketsName,
            PriceTickets = c.PriceTickets,
            TourDetailID = c.TourDeltaiId
            }).ToList();
        }

        public bool Update(AirlineTicketsDetailModel model)
        {
            if (model == null) return false;
            _context.airlineTicketDetails.Update(new AirlineTicketDetail()
            {
                CustomerId = model.CustomerID,
                AirlineTicketsName = model.AirlineTicketsName,
                AirlineTicketDetailId = model.AirlineTicketsID,
                PriceTickets = model.PriceTickets,
                TourDeltaiId = model.TourDetailID,
            });
            _context.SaveChanges();
            return true;
        }
    }
}
