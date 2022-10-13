using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.Configuration
{
    public class TourGuiderConfiguration : IEntityTypeConfiguration<TourGuider>
    {
        public void Configure(EntityTypeBuilder<TourGuider> builder)
        {
            builder.ToTable("TourGuider");
            builder.HasKey(c => c.TourGuiderId);
            builder.Property(c => c.TourGuiderId).UseIdentityColumn();
        }
    }
}
