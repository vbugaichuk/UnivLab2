using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AirportApp.Models;

namespace AirportApp.Models
{
    public class Flight
    {
        public Flight()
        {
            FlightsPlanes = new List<FlightsPlanes>();
            Tickets = new List<Ticket>();
        }
        public int Id { get; set; }


        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Рейс")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Час")]
        public DateTime Time { get; set; }

        public int AirportId { get; set; }

        public virtual Airport Airport { get; set; }

        public virtual ICollection<FlightsPlanes> FlightsPlanes { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
