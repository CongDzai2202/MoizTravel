using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;


namespace MoizTravel.WebAPI.Configuration
{
    public class ImformationCustomerConfiguration : IEntityTypeConfiguration<ImformationCustomer>
    {
        public void Configure(EntityTypeBuilder<ImformationCustomer> builder)
        {
            builder.ToTable("ImformationCustomer");
            builder.HasKey(x => x.CustomerId);
            builder.Property(c => c.CustomerId).UseIdentityColumn();

        }
    }
}
