using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {

        }

        // while creating models, set these associations
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<HotelRoom>().HasKey(hr => new { hr.HotelID, hr.RoomID });
            modelBuilder.Entity<RoomAmenities>().HasKey(ra => new { ra.AmenitiesID, ra.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   ID = 1,
                   Name = "Downtown Seattle",
                   StreetAddress = "123 1st Ave S",
                   Phone = "12065551234",
                   City = "Seattle",
                   State = "WA",
                   ZipCode = "98101"
               },
               new Hotel
               {
                   ID = 2,
                   Name = "Ballard",
                   StreetAddress = "1 Main St",
                   Phone = "12065551234",
                   City = "Seattle",
                   State = "WA",
                   ZipCode = "98107"
               },
               new Hotel
               {
                   ID = 3,
                   Name = "Downtown Renton",
                   StreetAddress = "1234 Rainier Ave S",
                   Phone = "12065551234",
                   City = "Renton",
                   State = "WA",
                   ZipCode = "98057"
               },
               new Hotel
               {
                   ID = 4,
                   Name = "Bellevue Square",
                   StreetAddress = "1 Bellevue Square",
                   Phone = "12065551234",
                   City = "Bellevue",
                   State = "WA",
                   ZipCode = "98004"
               },
               new Hotel
               {
                   ID = 5,
                   Name = "Everett",
                   StreetAddress = "3 Everett Way",
                   Phone = "12065551234",
                   City = "Everett",
                   State = "WA",
                   ZipCode = "98206"
               }
               );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Standard Studio",
                    Layout = Layout.Studio
                }, 
                new Room
                {
                    ID = 2,
                    Name = "Standard One Bedroom",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 3,
                    Name = "Standard Two Bedroom",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    ID = 4,
                    Name = "Pet Friendly Studio",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 5,
                    Name = "Pet Friendly One Bedroom",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 6,
                    Name = "Pet Friendly Two Bedroom",
                    Layout = Layout.TwoBedroom
                }
                );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Air Conditioning"
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Kitchenette"
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Jacuzzi Tub"
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Balcony"
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Office"
                }
                );
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
    }
}
