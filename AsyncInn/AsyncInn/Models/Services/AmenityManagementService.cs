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
            Amenities amenities = _context.Amenities.FirstOrDefault(a => a.ID == id);
            _context.Amenities.Remove(amenities);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Amenities>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task<Amenities> GetAmenity(int id)
        {
            return await _context.Amenities.FirstOrDefaultAsync(amenities => amenities.ID == id);
        }

        public void UpdateAmenity(Amenities amenities)
        {
            throw new NotImplementedException();
        }
    }
}
