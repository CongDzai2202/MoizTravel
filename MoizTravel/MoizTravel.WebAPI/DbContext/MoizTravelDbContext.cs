using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MoizTravel.WebAPI.Authentication;
using MoizTravel.WebAPI.Configuration;
using MoizTravel.WebAPI.Entities;

namespace MoizTravel.WebAPI.DbContext
{
    public class MoizTravelDbContext: IdentityDbContext<ApplicationUser>
    {
        public MoizTravelDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AirlineTicketsConfiguration());
            builder.ApplyConfiguration(new AirlineTicketsDetailsConfiguration());
            builder.ApplyConfiguration(new ImageNewsConfiguration());
            builder.ApplyConfiguration(new ImageTourConfiguration());
            builder.ApplyConfiguration(new ImformationCustomerConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new PlaceConfiguration());
            builder.ApplyConfiguration(new TourConfiguration());
            builder.ApplyConfiguration(new TourDetailsConfiguration());
            builder.ApplyConfiguration(new TourGuiderConfiguration());

            builder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims");
            builder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<string>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserToken<string>>().ToTable("AppUserTokens").HasKey(x => x.UserId);


        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<AirlineTicketDetail> airlineTicketDetails { get; set; }
        public DbSet<AirlineTickets> airlineTickets { get; set; }
        public DbSet<ImageNews> imageNews { get; set; }
        public DbSet<ImageTour> imageTours { get; set; }
        public DbSet<ImformationCustomer> imformationCustomers { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Place> places { get; set; }
        public DbSet<Tour> tours { get; set; }
        public DbSet<TourDetail> tourDetails { get; set; }
        public DbSet<TourGuider> tourGuiders { get; set; }
    }
}
