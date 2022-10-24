using MoizTravel.Model.ViewModel.Tour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface ITourDetailRepository
    {
        bool Create(TourDetailViewModel tourDetailView);
        bool Update(TourDetailViewModel tourDetailView);
        bool Delete(int id);
        List<TourDetailViewModel> GetList();
    }
}
