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
    public class ImageTourRepository : IImageTourRepository
    {
        private readonly MoizTravelDbContext _context;
        public ImageTourRepository(MoizTravelDbContext context)
        {
            _context = context;
        }
        public bool Create(ImageTourModel imageTour)
        {
            if (imageTour == null) return false;
            _context.imageTours.Add(new ImageTour()
            {                
                DateCreate=imageTour.DateCreate,
                Url=imageTour.Url,
                Note=imageTour.Note,
                TourDetailId=imageTour.TourDetailId,
                Status=imageTour.Status
            });
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            ImageTour imageTour = _context.imageTours.FirstOrDefault(c => c.ImageTourID == id);
            imageTour.Status = 1;
            _context.imageTours.Update(imageTour);
            _context.SaveChanges();
            return true;
        }

        public List<ImageTour> GetList()
        {
            return _context.imageTours.ToList();
        }

        public bool Update(ImageTourModel imageTour)
        {
            if (imageTour == null) return false;
            _context.imageTours.Update(new ImageTour()
            {               
                DateCreate = imageTour.DateCreate,
                Url = imageTour.Url,
                Note = imageTour.Note,
                TourDetailId = imageTour.TourDetailId,
                Status = imageTour.Status
            });
            return true;
        }
    }
}
