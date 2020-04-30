using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportApp.Models
{
    public class Ticket
    {
        public Ticket()
        {
            Passengers = new List<Passenger>();
        }
        public int PassengerId { get; set; }
        public int FlightId { get; set; }
        public int Id { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
    }
}
