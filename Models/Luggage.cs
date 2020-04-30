using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportApp.Models
{
    public class Luggage
    {
        public double Weight { get; set; }
        public int Id { get; set; }
        public int PassengerId { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}
