using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AirportApp.Models
{
    public class AirportAppContext: DbContext
    {
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<FlightsPlanes> FlightsPlanes { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Luggage> Luggages { get; set; }

        public AirportAppContext(DbContextOptions<AirportAppContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
