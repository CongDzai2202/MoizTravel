using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoizTravel.WebAPI.Authentication;

namespace MoizTravel.WebAPI.DbContext
{
    public class MoizTravelDbContext: IdentityDbContext<ApplicationUser>
    {
        public MoizTravelDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
