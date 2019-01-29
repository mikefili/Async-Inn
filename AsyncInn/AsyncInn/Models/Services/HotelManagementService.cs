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
        public Task CreateHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public void DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Hotel> GetHotel(int id)
        {
            throw new NotImplementedException();
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
