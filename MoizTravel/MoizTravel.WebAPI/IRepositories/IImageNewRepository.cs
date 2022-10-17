using MoizTravel.Model.NewsViewModel;
using MoizTravel.WebAPI.Entities;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface IImageNewRepository
    {
        bool Create(ImageNewViewModel imageNew);
        bool Update(ImageNewViewModel imageNew);
        bool Delete(int id);
        List<ImageNews> GetList();
    }
}
