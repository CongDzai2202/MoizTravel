using MoizTravel.Model.ViewModel.Pace;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface IPlaceRepository
    {
        bool Create(PlaceViewModel placeView);
        bool Update(PlaceViewModel placeView);
        bool Delete(int id);
        List<PlaceViewModel> GetList();
    }
}
