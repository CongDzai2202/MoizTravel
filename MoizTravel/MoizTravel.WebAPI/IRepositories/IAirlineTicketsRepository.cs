using MoizTravel.Model.ViewModel;
using MoizTravel.WebAPI.Entities;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface IAirlineTicketsRepository
    {
        bool Create(AirlineTicketsViewModel airlineTickets);
        bool Update(AirlineTicketsViewModel airlineTickets);
        bool Delete(int id);
        List<AirlineTickets> GetList();

    }
}
