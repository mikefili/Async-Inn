using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        public decimal RoomID { get; set; }
        public decimal Rate { get; set; }
        public bool MyProperty { get; set; }

        // navigation properties
        public ICollection<Hotel> Hotels { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
