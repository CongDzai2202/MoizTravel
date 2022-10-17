using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.News;
using MoizTravel.Model.ViewModel;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using MoizTravel.WebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineTicketsController : ControllerBase
    {
        private IAirlineTicketsRepository _airline;
        public AirlineTicketsController(IAirlineTicketsRepository airlineTickets)
        {
            _airline = airlineTickets;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            List<AirlineTickets> lst = _airline.GetList();
            var lstvm = lst.Select(c => new AirlineTickets()
            {
                AirlineTicketsId=c.AirlineTicketsId,
                StartLocation = c.StartLocation,
                EndLocation = c.EndLocation,
                FullName = c.FullName,
                DepartureTime = c.DepartureTime,
                NumberSeat = c.NumberSeat,
                FlightNumber = c.FlightNumber,
                DateStart = c.DateStart,
                Status = c.Status
            });
            return Ok(lstvm);
        }
        [HttpPost]
        public IActionResult Create(AirlineTicketsViewModel newView)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _airline.Create(newView);
            return CreatedAtAction(nameof(Create), a);
        }

        [HttpPut]
        public IActionResult Update(AirlineTicketsViewModel newView)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _airline.Update(newView);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _airline.Delete(id);
            return Ok();
        }
    }
}
