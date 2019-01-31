using System;
using Xunit;
using AsyncInn.Controllers;
using AsyncInn.Data;
using AsyncInn.Migrations;
using AsyncInn.Models;
using AsyncInn.Models.Interfaces;
using AsyncInn.Models.Services;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace UnitTests_AsyncInn
{
    public class HotelsUnitTests
    {
        [Fact]
        public void CanGetNameOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "Downtown Seattle";

            Assert.Equal("Downtown Seattle", hotel.Name);
        }

        [Fact]
        public void CanSetNameOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.Name = "Downtown Seattle";
            hotel.Name = "Seattle";

            Assert.Equal("Seattle", hotel.Name);
        }

        [Fact]
        public void CanGetStreetAddressOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.StreetAddress = "123 1st Ave S";

            Assert.Equal("123 1st Ave S", hotel.StreetAddress);
        }

        [Fact]
        public void CanSetStreetAddressOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.StreetAddress = "123 1st Ave S";
            hotel.StreetAddress = "456 2nd Ave S";

            Assert.Equal("456 2nd Ave S", hotel.StreetAddress);
        }

        [Fact]
        public void CanGetCityOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.City = "Seattle";

            Assert.Equal("Seattle", hotel.City);
        }

        [Fact]
        public void CanSetCityOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.City = "Seattle";
            hotel.City = "Georgetown";

            Assert.Equal("Georgetown", hotel.City);
        }

        [Fact]
        public void CanGetStateOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.State = "WA";

            Assert.Equal("WA", hotel.State);
        }

        [Fact]
        public void CanSetStateOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.State = "WA";
            hotel.State = "OR";

            Assert.Equal("OR", hotel.State);
        }

        [Fact]
        public void CanGetZipCodeOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.ZipCode = "98101";

            Assert.Equal("98101", hotel.ZipCode);
        }

        [Fact]
        public void CanSetZipCodeOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.ZipCode = "98101";
            hotel.ZipCode = "98102";

            Assert.Equal("98102", hotel.ZipCode);
        }

        [Fact]
        public void CanGetFormattedAddress()
        {
            Hotel hotel = new Hotel();
            hotel.StreetAddress = "123 1st Ave S";
            hotel.City = "Seattle";
            hotel.State = "WA";
            hotel.ZipCode = "98101";

            Assert.Equal("123 1st Ave S, Seattle, WA 98101", hotel.FormattedAddress);
        }

        [Fact]
        public void CanGetPhoneNumberOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.Phone = "1234567890";

            Assert.Equal("1234567890", hotel.Phone);
        }

        [Fact]
        public void CanSetPhoneNumberOfHotel()
        {
            Hotel hotel = new Hotel();
            hotel.Phone = "1234567890";
            hotel.Phone = "2345678901";

            Assert.Equal("2345678901", hotel.Phone);
        }

        [Fact]
        public async void CanCreateHotel()
        {
            DbContextOptions<AsyncInnDbContext> options = new DbContextOptionsBuilder<AsyncInnDbContext>().UseInMemoryDatabase("CreateHotel").Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                // Arrange
                Hotel hotel = new Hotel();
                hotel.ID = 1;
                hotel.Name = "Downtown Seattle";

                // Act
                HotelManagementService hotelManagementService = new HotelManagementService(context);
                await hotelManagementService.CreateHotel(hotel);
                var result = context.Hotels.FirstOrDefault(h => h.ID == hotel.ID);


                // Assert
                Assert.Equal(hotel, result);
            }
        }

        //[Fact]
        //public async void CanDeleteHotel()
        //{
        //    DbContextOptions<AsyncInnDbContext> options = new DbContextOptionsBuilder<AsyncInnDbContext>().UseInMemoryDatabase("DeleteHotel").Options;

        //    using (AsyncInnDbContext context = new AsyncInnDbContext(options))
        //    {
        //        // Arrange
        //        Hotel hotel = new Hotel();
        //        hotel.ID = 1;
        //        hotel.Name = "Downtown Seattle";

        //        // Act
        //        HotelManagementService hotelManagementService = new HotelManagementService(context);
        //        await hotelManagementService.DeleteHotel(hotel.ID);
        //        var result = context.Hotels.FirstOrDefault(h => h.ID == hotel.ID);


        //        // Assert
        //        Assert.Equal(hotel, result);
        //    }
        //}
    }

    public class RoomsUnitTests
    {

    }

    public class AmenitiesUnitTests
    {

    }
}
