using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourGuiderController : ControllerBase
    {
        private ITourGuiderRepository _tourGuider;
        public TourGuiderController(ITourGuiderRepository tourGuider)
        {
            _tourGuider = tourGuider;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<TourGuiderViewModel> lst = _tourGuider.GetList();
            return Ok(lst);
        }
        [HttpPost]
        public IActionResult Create(TourGuiderViewModel tourGuiderView)
        {
            var a = _tourGuider.Create(tourGuiderView);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(TourGuiderViewModel tourGuiderView)
        {
            _tourGuider.Update(tourGuiderView);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _tourGuider.Delete(id);
            return Ok();
        }
    }
}
