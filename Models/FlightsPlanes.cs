using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportApp.Models
{
    public class FlightsPlanes
    {
        public int FlightId { get; set; }
        public int PlaneId { get; set; }
        public int Id { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Plane Plane { get; set; }
        public int Duration { get; set; }
        public string Gate { get; set; }
    }
}
