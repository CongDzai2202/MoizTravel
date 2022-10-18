using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.Entities;
using System.Collections.Generic;

namespace MoizTravel.WebAPI.IRepositories
{
    public interface IImageTourRepository
    {
        bool Create(ImageTourModel imageTour);
        bool Update(ImageTourModel imageTour);
        bool Delete(int id);
        List<ImageTour> GetList();
    }
}
