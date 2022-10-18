using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MoizTravel.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageTourController : ControllerBase
    {
        private IImageTourRepository _imageTour;
        public ImageTourController(IImageTourRepository imageTour)
        {
            _imageTour = imageTour;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<ImageTour> lst = _imageTour.GetList();
            var lstv = lst.Select(c => new ImageTourModel()
            {
                ImageTourID=c.ImageTourID,
                DateCreate=c.DateCreate,
                Url=c.Url,
                Note=c.Note,
                TourDetailId=c.TourDetailId,
                Status=c.Status
            });
            return Ok(lstv);
        }
        [HttpPost]
        public IActionResult Create(ImageTourModel imageTour)
        {
            var a = _imageTour.Create(imageTour);
            return CreatedAtAction(nameof(Create), a);
        }
        [HttpPut]
        public IActionResult Update(ImageTourModel imageTour)
        {
            _imageTour.Update(imageTour);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _imageTour.Delete(id);
            return Ok();
        }
    }
}
