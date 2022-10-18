using MoizTravel.Model.ViewModel.Customer;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface IInfamationCustomerRepository
    {
        bool Create(CustomerViewModel customerView);
        bool Update(CustomerViewModel customerView);
        bool Delete(int id);
        List<CustomerViewModel> GetList();
    }
}
