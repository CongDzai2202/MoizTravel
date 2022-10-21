using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.ViewModel.Pace;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private IPlaceRepository _place;
        public PlaceController(IPlaceRepository place)
        {
            _place = place;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<PlaceViewModel> lst = _place.GetList();
            return Ok(lst);
        }
        [HttpPost]
        public IActionResult Create(PlaceViewModel placeView)
        {
            var a = _place.Create(placeView);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(PlaceViewModel placeView)
        {
            _place.Update(placeView);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _place.Delete(id);
            return Ok();
        }
    }
}
