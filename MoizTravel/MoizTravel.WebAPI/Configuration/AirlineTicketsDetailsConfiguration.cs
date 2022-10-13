﻿using System;
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
            builder.Property(c => c.AirlineTicketDetailId).UseIdentityColumn();
            builder.HasOne(x => x.AirlineTickets).WithMany(x => x.AirlineTicketDetails).HasForeignKey(x => x.AirlineTicketsId);
            //builder.HasOne(x => x.TourDetail).WithMany(x => x.AirlineTicketDetails).HasForeignKey(x => x.TourDeltaiId);
            builder.HasOne(x => x.ImformationCustomer).WithMany(x => x.AirlineTicketDetails).HasForeignKey(x => x.CustomerId);
        }
    }
}
