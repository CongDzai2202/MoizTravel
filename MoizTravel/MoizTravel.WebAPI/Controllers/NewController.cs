using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoizTravel.Model.News;
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
    public class NewController : ControllerBase
    {
        private INewRepository _new;
        public NewController(INewRepository newRepository)
        {
            _new = newRepository;
        }
        [HttpGet]
        public IActionResult GetList()
        {
            List<News> news = _new.GetList();
            var lstnew = news.Select(c => new NewViewModel()
            {
                NewsId = c.NewsId,
                Title = c.Title,
                Content = c.Content,
                PostDate = c.PostDate,
                ImageNewId = c.ImageNewId,
                Status = c.Status
            });
            return Ok(lstnew);
        }
        [HttpPost]
        public IActionResult Create(NewViewModel newView)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var a = _new.Create(newView);
            return CreatedAtAction(nameof(Create),a);
        }
        [HttpPut]
        public IActionResult Update(NewViewModel newView)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _new.Update(newView);
            return Ok();
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            _new.Delete(id);
            return Ok();
        }
    }
}
