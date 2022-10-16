using MoizTravel.Model.News;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MoizTravel.WebAPI.Repositories
{
    public class NewRepository : INewRepository
    {
        private readonly MoizTravelDbContext _context;
        public NewRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(NewViewModel newViewModel)
        {
            if (newViewModel == null) return false;
            _context.news.Add(new News()
            {
                Title=newViewModel.Title,
                Content = newViewModel.Content,
                PostDate=newViewModel.PostDate,
                ImageNewId=newViewModel.ImageNewId,
                Status=newViewModel.Status
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            News news = _context.news.FirstOrDefault(c=>c.NewsId==id);
            news.Status = 1;
            _context.news.Update(news);
            _context.SaveChanges();
            return true;
        }

        public List<News> GetList()
        {
            return _context.news.ToList();
        }

        public bool Update(NewViewModel newViewModel)
        {
            if (newViewModel == null) return false;
            _context.news.Update(new News()
            {
                Title = newViewModel.Title,
                Content = newViewModel.Content,
                PostDate = newViewModel.PostDate,
                ImageNewId = newViewModel.ImageNewId,
                Status = newViewModel.Status
            });
            _context.SaveChanges();
            return true;
        }
    }
}
