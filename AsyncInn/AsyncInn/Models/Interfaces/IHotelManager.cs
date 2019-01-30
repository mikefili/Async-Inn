using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        // Create a hotel
        Task CreateHotel(Hotel hotel);

        // Read a hotel
        Task<Hotel> GetHotel(int id);

        Task<IEnumerable<Hotel>> GetHotels();

        // Update a hotel
        Task UpdateHotel(Hotel hotel);

        // Delete a hotel
        Task DeleteHotel(int id);
    }
}
