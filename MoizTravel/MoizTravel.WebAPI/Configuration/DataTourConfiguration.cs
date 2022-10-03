using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.Configuration
{
    public class DataTourConfiguration:IEntityTypeConfiguration<DataTour>
    {
        public void Configure(EntityTypeBuilder<DataTour> builder)
        {
            builder.ToTable("DataTour");
            builder.HasKey(x => x.DataTourId);
        }
    }
}
