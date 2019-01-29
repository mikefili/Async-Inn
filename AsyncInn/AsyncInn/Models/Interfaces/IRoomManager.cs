using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    interface IRoomManager
    {
        // Create a room
        Task CreateRoom(Room room);

        // Read a room
        Task<Room> GetRoom(int id);

        Task<IEnumerable<Room>> GetRooms();

        // Update a room
        void UpdateRoom(Room room);

        // Delete a room
        void DeleteRoom(int id);
    }
}
