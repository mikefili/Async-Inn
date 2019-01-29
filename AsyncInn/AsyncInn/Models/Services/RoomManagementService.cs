using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AsyncInn.Models.Services
{
    public class RoomManagementService : IRoomManager
    {
        private AsyncInnDbContext _context { get; }

        public RoomManagementService(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        public void DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Room>> GetRooms()
        {
            throw new NotImplementedException();
        }

        public void UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
