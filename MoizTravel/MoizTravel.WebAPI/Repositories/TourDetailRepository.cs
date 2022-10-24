using MoizTravel.Model.ViewModel.Tour;
using MoizTravel.WebAPI.DbContext;
using MoizTravel.WebAPI.Entities;
using MoizTravel.WebAPI.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoizTravel.WebAPI.Repositories
{
    public class TourDetailRepository : ITourDetailRepository
    {
        private readonly MoizTravelDbContext _context;
        public TourDetailRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(TourDetailViewModel tourDetailView)
        {
            if (tourDetailView == null) return false;
            _context.tourDetails.Add(new TourDetail()
            {
                TourId = tourDetailView.TourId,
                TourGuiderId = tourDetailView.TourGuiderId,
                TourDetailName = tourDetailView.TourDetailName,
                TotalAmount = tourDetailView.TotalAmount,
                Status = 0
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            TourDetail tourDetail = _context.tourDetails.FirstOrDefault(c => c.TourDetailId == id);
            tourDetail.Status = 1;
            _context.tourDetails.Update(tourDetail);
            _context.SaveChanges();
            return true;
        }

        public List<TourDetailViewModel> GetList()
        {
            return _context.tourDetails.Select(c => new TourDetailViewModel()
            {
                TourDetailId=c.TourDetailId,
                TourId=c.TourId,
                TourGuiderId=c.TourGuiderId,
                TourDetailName=c.TourDetailName,
                TotalAmount=c.TotalAmount,
                Status=c.Status
            }).ToList();
        }

        public bool Update(TourDetailViewModel tourDetailView)
        {
            if (tourDetailView == null) return false;
            _context.tourDetails.Update(new TourDetail()
            {
                TourId = tourDetailView.TourId,
                TourGuiderId = tourDetailView.TourGuiderId,
                TourDetailName = tourDetailView.TourDetailName,
                TotalAmount = tourDetailView.TotalAmount
            });
            _context.SaveChanges();
            return true;
        }
    }
}
