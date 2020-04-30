using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AirportApp.Models;

namespace AirportApp.Models
{
    public class Airport
    {
        public Airport()
        {
            Flights = new List<Flight>();
        }

        public int Id { get; set; }


        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Аеропорт")]
        public string Name { get; set; }


        [Display(Name = "Інформація про аеропорт")]
        public string Info { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }

    }

    
}
