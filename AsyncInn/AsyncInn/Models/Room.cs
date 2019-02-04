using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide a name for the room")]
        [Display(Name = "Room Name ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a layout for the room")]
        [Display(Name = "Room Layout ")]
        public Layout Layout { get; set; }

        // navigation properties
        public ICollection<HotelRoom> HotelRooms { get; set; }
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
    }

    public enum Layout
    {
        Studio,
        OneBedroom,
        TwoBedroom
    }
}
