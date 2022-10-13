﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.Configuration
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.ToTable("Place");
            builder.HasKey(c => c.PlaceId);
            builder.Property(c => c.PlaceId).UseIdentityColumn();
            builder.HasOne(x => x.TourDetail).WithMany(x => x.Places).HasForeignKey(x => x.TourDetailId);
        }
    }
}
