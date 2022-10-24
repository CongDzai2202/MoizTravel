using MoizTravel.Model.ViewModel.Pace;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System.Collections.Generic;
using System.Linq;

namespace MoizTravel.WebAPI.Repositories
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly MoizTravelDbContext _context;
        public PlaceRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(PlaceViewModel placeView)
        {
            if (placeView == null) return false;
            _context.places.Add(new Place()
            {
                PlaceName=placeView.PlaceName,
                Discription=placeView.Discription,
                TourDetailId=placeView.TourDetailId,
                Status=0
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            Place place = _context.places.FirstOrDefault(c=>c.PlaceId==id);
            place.Status = 1;
            _context.Update(place);
            _context.SaveChanges();
            return true;
        }

        public List<PlaceViewModel> GetList()
        {
            return _context.places.Select(c=>new PlaceViewModel()
            {
                PlaceId=c.PlaceId,
                PlaceName=c.PlaceName,
                Discription=c.Discription,
                TourDetailId=c.TourDetailId,
                Status=c.Status
            }).ToList();
        }

        public bool Update(PlaceViewModel placeView)
        {
            if (placeView == null) return false;
            _context.places.Update(new Place()
            {
                PlaceName = placeView.PlaceName,
                Discription = placeView.Discription,
                TourDetailId = placeView.TourDetailId
            });
            _context.SaveChanges();
            return true;
        }
    }
}
