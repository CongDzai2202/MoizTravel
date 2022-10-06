using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.Configuration
{
    public class TourDetailsConfiguration : IEntityTypeConfiguration<TourDetail>
    {
        public void Configure(EntityTypeBuilder<TourDetail> builder)
        {
            builder.ToTable("TourDetails");
            builder.HasKey(x => x.TourDetailId);
            builder.HasOne(x => x.Tour).WithMany(x => x.TourDetails).HasForeignKey(x => x.TourId);
            builder.HasOne(x => x.TourGuider).WithMany(x => x.TourDetails).HasForeignKey(x => x.TourGuiderId);
        }
    }
}
