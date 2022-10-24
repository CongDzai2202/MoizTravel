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
    public class TourDetailController : ControllerBase
    {
        private ITourDetailRepository _tourDetail;
        public TourDetailController(ITourDetailRepository tourDetail)
        {
            _tourDetail = tourDetail;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<TourDetailViewModel> lst = _tourDetail.GetList();
            return Ok(lst);
        }
        [HttpPost]
        public IActionResult Create(TourDetailViewModel tourDetailView)
        {
            var a = _tourDetail.Create(tourDetailView);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(TourDetailViewModel tourDetailView)
        {
            _tourDetail.Update(tourDetailView);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _tourDetail.Delete(id);
            return Ok();
        }
    }
}
