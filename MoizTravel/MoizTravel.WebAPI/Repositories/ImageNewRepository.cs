using MoizTravel.Model.NewsViewModel;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Repositories
{
    public class ImageNewRepository : IImageNewRepository
    {
        private readonly MoizTravelDbContext _context;
        public ImageNewRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(ImageNewViewModel imageNew)
        {
            if (imageNew == null) return false;
            _context.imageNews.Add(new ImageNews()
            {               
                Url=imageNew.Url,
                Note=imageNew.Note,
                Status=0
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            ImageNews imageNews = _context.imageNews.FirstOrDefault(c => c.ImageNewId == id);
            imageNews.Status = 1;
            _context.imageNews.Update(imageNews);
            _context.SaveChanges();
            return true;
        }

        public List<ImageNews> GetList()
        {
            return _context.imageNews.ToList();
        }

        public bool Update(ImageNewViewModel imageNew)
        {
            if (imageNew == null) return false;
            _context.imageNews.Update(new ImageNews()
            {               
                Url = imageNew.Url,
                Note = imageNew.Note
            });
            _context.SaveChanges();
            return true;
        }
    }
}
