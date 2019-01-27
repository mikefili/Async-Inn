using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide a name for the hotel")]
        [Display(Name = "Hotel Name ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide an address for the hotel")]
        [Display(Name = "Hotel Address ")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please provide a phone number for the hotel")]
        [Display(Name = "Hotel Phone Number ")]
        [Phone]
        public string Phone { get; set; }

        // navigation properties
        public ICollection<HotelRoom> HotelRoom { get; set; }
    }
}
