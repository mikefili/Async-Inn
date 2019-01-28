using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Amenities
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide a name for the amenity")]
        [Display(Name = "Amenity Name ")]
        public string Name { get; set; }

        // navigation properties
        public RoomAmenities RoomAmenities { get; set; }
    }
}
