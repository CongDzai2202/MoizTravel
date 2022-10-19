using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : ControllerBase
    {
        private ITourRepository _tour;
        public TourController(ITourRepository tour)
        {
            _tour = tour;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<TourViewModel> lst = _tour.GetList();
            return Ok(lst);
        }
        [HttpPost]
        public IActionResult Create(TourViewModel tourView)
        {
            var a = _tour.Create(tourView);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(TourViewModel tourView)
        {
            _tour.Update(tourView);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _tour.Delete(id);
            return Ok();
        }
    }
}
