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
                   Address = "123 1st Ave S, Seattle, WA 98101",
                   Phone = "12065551234"
               },
               new Hotel
               {
                   ID = 2,
                   Name = "Ballard",
                   Address = "1 Main St, Seattle, WA 98107",
                   Phone = "12065551234"
               },
               new Hotel
               {
                   ID = 3,
                   Name = "Downtown Renton",
                   Address = "1234 Rainier Ave S, Renton, WA 98057",
                   Phone = "12065551234"
               },
               new Hotel
               {
                   ID = 4,
                   Name = "Bellevue Square",
                   Address = "1 Bellevue Square, Bellevue, WA 98004",
                   Phone = "12065551234"
               },
               new Hotel
               {
                   ID = 5,
                   Name = "Everett",
                   Address = "3 Everett Way, Everett, WA 98206",
                   Phone = "12065551234"
               }
               );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Standard Studio",
                    Layout = Layout.Studio
                }, new Room
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
