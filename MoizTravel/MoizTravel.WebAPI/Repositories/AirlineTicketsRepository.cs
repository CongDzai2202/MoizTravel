using MoizTravel.Model.ViewModel;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Repositories
{
    public class AirlineTicketsRepository : IAirlineTicketsRepository
    {
        private readonly MoizTravelDbContext _context;
        public AirlineTicketsRepository(MoizTravelDbContext moizTravelDb)
        {
            _context = moizTravelDb;
        }

        public bool Create(AirlineTicketsViewModel airlineTickets)
        {
            if (airlineTickets == null) return false;
            _context.airlineTickets.Add(new AirlineTickets()
            {                
                StartLocation=airlineTickets.StartLocation,
                EndLocation=airlineTickets.EndLocation,
                FullName=airlineTickets.FullName,
                DepartureTime=airlineTickets.DepartureTime,
                NumberSeat=airlineTickets.NumberSeat,
                FlightNumber=airlineTickets.FlightNumber,
                DateStart=airlineTickets.DateStart,
                Status=airlineTickets.Status
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            AirlineTickets airlineTickets = _context.airlineTickets.FirstOrDefault(c => c.AirlineTicketsId == id);
            airlineTickets.Status = 1;
            _context.airlineTickets.Update(airlineTickets);
            _context.SaveChanges();
            return true;
        }

        public List<AirlineTickets> GetList()
        {
            return _context.airlineTickets.ToList();
        }

        public bool Update(AirlineTicketsViewModel airlineTickets)
        {
            if (airlineTickets == null) return false;
            _context.airlineTickets.Update(new AirlineTickets()
            {
                StartLocation = airlineTickets.StartLocation,
                EndLocation = airlineTickets.EndLocation,
                FullName = airlineTickets.FullName,
                DepartureTime = airlineTickets.DepartureTime,
                NumberSeat = airlineTickets.NumberSeat,
                FlightNumber = airlineTickets.FlightNumber,
                DateStart = airlineTickets.DateStart,
                Status = airlineTickets.Status
            });
            _context.SaveChanges();
            return true;
        }
    }
}
