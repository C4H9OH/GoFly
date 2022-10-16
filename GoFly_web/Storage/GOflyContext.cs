using GoFly_web.Storage.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GoFly_web.Storage
{
    public class GOflyContext:DbContext
    {
        public GOflyContext(DbContextOptions<GOflyContext> options) : base(options)
        {
          
        }

        public DbSet<ArrivalCity> ArrivalCities { get; set; }

        public DbSet<DepartureCity> DepartureCities { get; set; }

        public DbSet<Itinerary> Itineraries { get; set; }

        public DbSet<ArrivalCountry> ArrivalCountries { get; set; }

        public DbSet<DepartureCountry> DepartureCountries { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Transport> Transports { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Wishlist> Wishlists { get; set; }

        public DbSet<Feedback> Feedbacks { get; set; }



    }
}
