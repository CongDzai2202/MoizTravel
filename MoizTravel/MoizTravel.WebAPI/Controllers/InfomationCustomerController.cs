using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.ViewModel.Customer;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfomationCustomerController : ControllerBase
    {
        private IInfamationCustomerRepository _customer;
        public InfomationCustomerController(IInfamationCustomerRepository customerRepository)
        {
            _customer = customerRepository;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<CustomerViewModel> lst = _customer.GetList();
            return Ok(lst);
        }
        [HttpPost]
        public IActionResult Create(CustomerViewModel customer)
        {
            var a = _customer.Create(customer);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(CustomerViewModel customer)
        {
            _customer.Update(customer);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _customer.Delete(id);
            return Ok();
        }
    }
}
