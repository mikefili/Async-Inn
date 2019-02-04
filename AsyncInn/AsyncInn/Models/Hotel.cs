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

        [Required(ErrorMessage = "Please provide a street address")]
        [Display(Name = "Street Address ")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Please provide a city")]
        [Display(Name = "City ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please provide a state")]
        [StringLength(2)]
        [Display(Name = "State ")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please provide a zip code")]
        [StringLength(5)]
        [Display(Name = "5 Digit Zip Code ")]
        public string ZipCode { get; set; }

        [Display(Name = "Address ")]
        public string FormattedAddress
        {
            get
            {
                return $"{StreetAddress}, {City}, {State.ToUpper()} {ZipCode}";
            }
        }

        [Required(ErrorMessage = "Please provide a phone number for the hotel")]
        [Display(Name = "Phone Number ")]
        [Phone]
        public string Phone { get; set; }

        // navigation properties
        public ICollection<HotelRoom> HotelRooms { get; set; }
    }
}
