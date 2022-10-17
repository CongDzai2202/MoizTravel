using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.NewsViewModel;
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
    public class ImageNewController : ControllerBase
    {
        private readonly IImageNewRepository _imageNew;
        public ImageNewController(IImageNewRepository imageNew)
        {
            _imageNew = imageNew;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<ImageNews> lstimg = _imageNew.GetList();
            var lstv = lstimg.Select(c => new ImageNewViewModel()
            {
                ImageNewId=c.ImageNewId,
                Note=c.Note,
                Url=c.Url,
                Status=c.Status
            });
            return Ok(lstv);
        }
        [HttpPost]
        public IActionResult Create(ImageNewViewModel imageNew)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _imageNew.Create(imageNew);
            return CreatedAtAction(nameof(Create),a);
        }
        [HttpPut]
        public IActionResult Update(ImageNewViewModel imageNew)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _imageNew.Update(imageNew);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _imageNew.Delete(id);
            return Ok();
        }
    }
}
