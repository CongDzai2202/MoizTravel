using MoizTravel.Model.ViewModel.Customer;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MoizTravel.WebAPI.Repositories
{
    public class InfomationCustomerRepository : IInfamationCustomerRepository
    {
        private readonly MoizTravelDbContext _context;
        public InfomationCustomerRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(CustomerViewModel customerView)
        {
            if (customerView == null) return false;
            _context.imformationCustomers.Add(new ImformationCustomer()
            {
                FullName = customerView.FullName,
                Image = customerView.Image,
                Gender = customerView.Gender,
                PhoneNumber = customerView.PhoneNumber,
                Email = customerView.Email,
                CompanyAddress = customerView.CompanyAddress,
                CompanyName = customerView.CompanyName,
                CompanyTel = customerView.CompanyTel,
                Status = customerView.Status
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            ImformationCustomer customer = _context.imformationCustomers.FirstOrDefault(c=>c.CustomerId==id);
            customer.Status = 1;
            _context.Update(customer);
            _context.SaveChanges();
            return true;
        }

        public List<CustomerViewModel> GetList()
        {
            return _context.imformationCustomers.Select(c => new CustomerViewModel()
            {
                CustomerId = c.CustomerId,
                FullName = c.FullName,
                Image = c.Image,
                Gender = c.Gender,
                PhoneNumber = c.PhoneNumber,
                Email = c.Email,
                CompanyAddress = c.CompanyAddress,
                CompanyName = c.CompanyName,
                CompanyTel = c.CompanyTel,
                Status = c.Status
            }).ToList();
        }

        public bool Update(CustomerViewModel customerView)
        {
            if (customerView == null) return false;
            _context.imformationCustomers.Update(new ImformationCustomer()
            {
                FullName = customerView.FullName,
                Image = customerView.Image,
                Gender = customerView.Gender,
                PhoneNumber = customerView.PhoneNumber,
                Email = customerView.Email,
                CompanyAddress = customerView.CompanyAddress,
                CompanyName = customerView.CompanyName,
                CompanyTel = customerView.CompanyTel,
                Status = customerView.Status
            });
            _context.SaveChanges();
            return true;
        }
    }
}
