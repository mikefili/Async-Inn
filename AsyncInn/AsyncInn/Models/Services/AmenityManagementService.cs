using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Models.Services
{
    public class AmenityManagementService : IAmenityManager
    {
        private AsyncInnDbContext _context { get; }

        public AmenityManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateAmenity(Amenities amenities)
        {
            _context.Amenities.Add(amenities);
            await _context.SaveChangesAsync();
        }

        public void DeleteAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Amenities>> GetAmenities()
        {
            throw new NotImplementedException();
        }

        public Task<Amenities> GetAmenity(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }
    }
}
