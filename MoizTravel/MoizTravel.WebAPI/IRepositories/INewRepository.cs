using MoizTravel.Model.News;
using MoizTravel.WebAPI.Entities;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface INewRepository
    {
        bool Create(NewViewModel newViewModel);
        bool Update(NewViewModel newViewModel);
        bool Delete(int id);
        List<News> GetList();
    }
}
