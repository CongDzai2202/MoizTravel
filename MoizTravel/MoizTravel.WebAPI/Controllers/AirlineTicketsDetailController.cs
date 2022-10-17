using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.ViewModel.ArlineTickets;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineTicketsDetailController : ControllerBase
    {
        private IAirlineTicketsDetailRepository _airline;
        public AirlineTicketsDetailController(IAirlineTicketsDetailRepository airlineTickets)
        {
            _airline = airlineTickets;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            _airline.GetList();
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(AirlineTicketsDetailModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _airline.Create(model);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(AirlineTicketsDetailModel model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _airline.Update(model);
            return Ok();
        }
        [HttpPut]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _airline.Delete(id);
            return Ok();
        }
    }
}
