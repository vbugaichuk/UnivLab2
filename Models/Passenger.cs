using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirportApp.Models
{
    public class Passenger
    {
        public Passenger()
        {
            Luggages = new List<Luggage>();

        }
        public string Name { get; set; }

        public int Id { get; set; }

        public virtual ICollection<Luggage> Luggages { get; set; }

    }
}
