﻿// <auto-generated />
using System;
using MagicVilla_VillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230705042057_addUsersToDb")]
    partial class addUsersToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("LocalUsers");
                });

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(3000)
                        .HasColumnType("nvarchar(3000)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Fireplace, Hiking trails, Sauna",
                            CreatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8943),
                            Details = "Escape to the tranquility of this luxurious villa nestled in the mountains.",
                            ImageURL = "https://example.com/villa2_image.jpg",
                            Name = "Mountain Retreat Villa",
                            Occupancy = 6,
                            Rate = 4.7000000000000002,
                            Sqft = 3500,
                            UpdatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8956)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Private beach access, Outdoor dining area, Spa",
                            CreatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8958),
                            Details = "Experience the ultimate beachfront getaway in this stunning villa.",
                            ImageURL = "https://example.com/villa1_image.jpg",
                            Name = "Beach View",
                            Occupancy = 10,
                            Rate = 4.5,
                            Sqft = 4500,
                            UpdatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8958)
                        },
                        new
                        {
                            Id = 3,
                            Amenity = "Swimming pool, Jacuzzi, Gym, BBQ area",
                            CreatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8960),
                            Details = "This exquisite villa offers stunning views and luxurious amenities.",
                            ImageURL = "https://example.com/villa_image.jpg",
                            Name = "Luxury Villa",
                            Occupancy = 8,
                            Rate = 5.0,
                            Sqft = 5000,
                            UpdatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8960)
                        },
                        new
                        {
                            Id = 4,
                            Amenity = "Hot tub, Nature trails, Outdoor seating area",
                            CreatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8962),
                            Details = "Experience privacy and serenity in this secluded villa surrounded by nature.",
                            ImageURL = "https://example.com/villa4_image.jpg",
                            Name = "Secluded Villa in the Woods",
                            Occupancy = 4,
                            Rate = 4.0,
                            Sqft = 3000,
                            UpdatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8963)
                        },
                        new
                        {
                            Id = 5,
                            Amenity = "Infinity pool, Home theater, Outdoor lounge area",
                            CreatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8964),
                            Details = "Indulge in modern elegance and relax by the private pool in this stylish villa.",
                            ImageURL = "https://example.com/villa3_image.jpg",
                            Name = "Modern Villa with Pool",
                            Occupancy = 8,
                            Rate = 4.2000000000000002,
                            Sqft = 4000,
                            UpdatedDate = new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8965)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
