using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.Configuration
{
    public class AirlineTicketsConfiguration : IEntityTypeConfiguration<AirlineTickets>
    {
        public void Configure(EntityTypeBuilder<AirlineTickets> builder)
        {
            builder.ToTable("AirLineTickets");
            builder.HasKey(c => c.AirlineTicketsId);
            builder.Property(c => c.AirlineTicketsId).UseIdentityColumn();

        }
    }
}
