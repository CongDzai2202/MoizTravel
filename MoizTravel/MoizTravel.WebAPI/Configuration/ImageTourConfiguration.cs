using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;


namespace MoizTravel.WebAPI.Configuration
{
    public class ImageTourConfiguration : IEntityTypeConfiguration<ImageTour>
    {
        public void Configure(EntityTypeBuilder<ImageTour> builder)
        {
            builder.ToTable("ImageTour");
            builder.HasKey(x => x.ImageTourID);
        }
    }
}
