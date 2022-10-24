using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MoizTravel.WebAPI.Repositories
{
    public class TourGuiderRepository : ITourGuiderRepository
    {
        private readonly MoizTravelDbContext _context;
        public TourGuiderRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(TourGuiderViewModel tourGuiderView)
        {
            if (tourGuiderView == null) return false;
            _context.tourGuiders.Add(new TourGuider()
            {
                Name = tourGuiderView.Name,
                BirthDate = tourGuiderView.BirthDate,
                Address = tourGuiderView.Address,
                PhoneNumber = tourGuiderView.PhoneNumber,
                Image = tourGuiderView.Image,
                Status = 0
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            TourGuider tourGuider = _context.tourGuiders.FirstOrDefault(c => c.TourGuiderId == id);
            tourGuider.Status = 1;
            _context.Update(tourGuider);
            _context.SaveChanges();
            return true;
        }

        public List<TourGuiderViewModel> GetList()
        {
            return _context.tourGuiders.Select(c => new TourGuiderViewModel()
            {
                TourGuiderId=c.TourGuiderId,
                Name = c.Name,
                BirthDate = c.BirthDate,
                Address = c.Address,
                PhoneNumber = c.PhoneNumber,
                Image = c.Image,
                Status = c.Status
            }).ToList();
        }

        public bool Update(TourGuiderViewModel tourGuiderView)
        {
            if (tourGuiderView == null) return false;
            _context.tourGuiders.Update(new TourGuider()
            {
                Name = tourGuiderView.Name,
                BirthDate = tourGuiderView.BirthDate,
                Address = tourGuiderView.Address,
                PhoneNumber = tourGuiderView.PhoneNumber,
                Image = tourGuiderView.Image
            });
            _context.SaveChanges();
            return true;
        }
    }
}
