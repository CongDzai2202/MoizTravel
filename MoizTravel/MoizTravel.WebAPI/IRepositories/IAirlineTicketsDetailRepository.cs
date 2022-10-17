using MoizTravel.Model.ViewModel.ArlineTickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface IAirlineTicketsDetailRepository
    {
        bool Create(AirlineTicketsDetailModel model);
        bool Update(AirlineTicketsDetailModel model);
        bool Delete(int id);
        List<AirlineTicketsDetailModel> GetList();
    }
}
