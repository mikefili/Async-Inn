using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    interface IAmenityManager
    {
        // Create an amenity
        Task CreateAmenity(Amenities amenities);

        // Read an amenity
        Task<Amenities> GetAmenity(int id);

        Task<IEnumerable<Amenities>> GetAmenities();

        // Update an amenity
        void UpdateAmenity(Amenities amenities);

        // Delete an amenity
        void DeleteAmenity(int id);
    }
}
