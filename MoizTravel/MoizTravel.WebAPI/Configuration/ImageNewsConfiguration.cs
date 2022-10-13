using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoizTravel.WebAPI.Entities;


namespace MoizTravel.WebAPI.Configuration
{
    public class ImageNewsConfiguration : IEntityTypeConfiguration<ImageNews>
    {
        public void Configure(EntityTypeBuilder<ImageNews> builder)
        {
            builder.ToTable("ImageNews");
            builder.HasKey(x => x.ImageNewId);
            builder.Property(c => c.ImageNewId).UseIdentityColumn();
        }
    }
}
