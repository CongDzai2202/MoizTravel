using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.Configuration
{
    public class AirlineTicketsDetailsConfiguration:IEntityTypeConfiguration<AirlineTicketDetail>
    {
        public void Configure(EntityTypeBuilder<AirlineTicketDetail> builder)
        {
            builder.ToTable("AirlineTicketDetail");
            builder.HasKey(x => x.AirlineTicketDetailId);
        }
    }
}
