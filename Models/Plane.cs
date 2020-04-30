using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportApp.Models
{
    public class Plane
    {
        public Plane()
        {
            FlightsPlanes = new List<FlightsPlanes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Info { get; set; }
        public virtual ICollection<FlightsPlanes> FlightsPlanes { get; set; }
    }
}
