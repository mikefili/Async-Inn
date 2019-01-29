using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Models.Services
{
    public class HotelManagementService : IHotelManager
    {
        private AsyncInnDbContext _context { get; }

        public HotelManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public void DeleteHotel(int id)
        {
            Hotel hotel = _context.Hotels.FirstOrDefault(h => h.ID == id);
            _context.Hotels.Remove(hotel);
            _context.SaveChanges();
        }

        public async Task<Hotel> GetHotel(int id)
        {
            return await _context.Hotels.FirstOrDefaultAsync(hotel => hotel.ID == id);
        }

        public Task<IEnumerable<Hotel>> GetHotels()
        {
            throw new NotImplementedException();
        }

        public void UpdateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
