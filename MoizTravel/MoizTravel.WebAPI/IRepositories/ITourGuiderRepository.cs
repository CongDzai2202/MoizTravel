using MoizTravel.Model.ViewModel.Tour;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface ITourGuiderRepository
    {
        bool Create(TourGuiderViewModel tourGuiderView);
        bool Update(TourGuiderViewModel tourGuiderView);
        bool Delete(int id);
        List<TourGuiderViewModel> GetList();
    }
}
