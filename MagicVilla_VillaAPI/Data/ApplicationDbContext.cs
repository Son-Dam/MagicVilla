using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new()
                {
                    Id = 1,
                    Name = "Mountain Retreat Villa",
                    Details = "Escape to the tranquility of this luxurious villa nestled in the mountains.",
                    Rate = 4.7,
                    Sqft = 3500,
                    Occupancy = 6,
                    ImageURL = "https://example.com/villa2_image.jpg",
                    Amenity = "Fireplace, Hiking trails, Sauna",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new()
                {
                    Id = 2,
                    Name = "Beach View",
                    Details = "Experience the ultimate beachfront getaway in this stunning villa.",
                    Rate = 4.5,
                    Sqft = 4500,
                    Occupancy = 10,
                    ImageURL = "https://example.com/villa1_image.jpg",
                    Amenity = "Private beach access, Outdoor dining area, Spa",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new()
                {
                    Id = 3,
                    Name = "Luxury Villa",
                    Details = "This exquisite villa offers stunning views and luxurious amenities.",
                    Rate = 5.0,
                    Sqft = 5000,
                    Occupancy = 8,
                    ImageURL = "https://example.com/villa_image.jpg",
                    Amenity = "Swimming pool, Jacuzzi, Gym, BBQ area",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new()
                {
                    Id = 4,
                    Name = "Secluded Villa in the Woods",
                    Details = "Experience privacy and serenity in this secluded villa surrounded by nature.",
                    Rate = 4.0,
                    Sqft = 3000,
                    Occupancy = 4,
                    ImageURL = "https://example.com/villa4_image.jpg",
                    Amenity = "Hot tub, Nature trails, Outdoor seating area",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                },
                new()
                {
                    Id = 5,
                    Name = "Modern Villa with Pool",
                    Details = "Indulge in modern elegance and relax by the private pool in this stylish villa.",
                    Rate = 4.2,
                    Sqft = 4000,
                    Occupancy = 8,
                    ImageURL = "https://example.com/villa3_image.jpg",
                    Amenity = "Infinity pool, Home theater, Outdoor lounge area",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now
                }) ;
        }
    }
}
