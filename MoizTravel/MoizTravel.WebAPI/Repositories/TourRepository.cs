using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MoizTravel.WebAPI.Repositories
{
    public class TourRepository : ITourRepository
    {
        private readonly MoizTravelDbContext _context;
        public TourRepository(MoizTravelDbContext context)
        {
            _context = context;
        }

        public bool Create(TourViewModel tourView)
        {
            if (tourView == null) return false;
            _context.tours.Add(new Tour()
            {
                TourName = tourView.TourName,
                Address = tourView.Address,
                PlaceGo = tourView.PlaceGo,
                Price = tourView.Price,
                DateStart = tourView.DateStart,
                DateEnd = tourView.DateEnd,
                StartLocation = tourView.StartLocation,
                EndLocation = tourView.EndLocation,
                Status = tourView.Status
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            Tour tour = _context.tours.FirstOrDefault(c => c.TourId == id);
            tour.Status = 1;
            _context.tours.Update(tour);
            _context.SaveChanges();
            return true;
        }

        public List<TourViewModel> GetList()
        {
            return _context.tours.Select(c => new TourViewModel()
            {
                TourId=c.TourId,
                TourName = c.TourName,
                Address = c.Address,
                PlaceGo = c.PlaceGo,
                Price = c.Price,
                DateStart = c.DateStart,
                DateEnd = c.DateEnd,
                StartLocation = c.StartLocation,
                EndLocation = c.EndLocation,
                Status = c.Status
            }).ToList();
        }

        public bool Update(TourViewModel tourView)
        {
            if (tourView == null) return false;
            _context.tours.Update(new Tour()
            {
                TourName = tourView.TourName,
                Address = tourView.Address,
                PlaceGo = tourView.PlaceGo,
                Price = tourView.Price,
                DateStart = tourView.DateStart,
                DateEnd = tourView.DateEnd,
                StartLocation = tourView.StartLocation,
                EndLocation = tourView.EndLocation,
                Status = tourView.Status
            });
            _context.SaveChanges();
            return true;
        }
    }
}
