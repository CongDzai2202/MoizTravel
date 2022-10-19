using MoizTravel.Model.ViewModel.Tour;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface ITourRepository
    {
        bool Create(TourViewModel tourView);
        bool Update(TourViewModel tourView);
        bool Delete(int id);
        List<TourViewModel> GetList();
    }
}
