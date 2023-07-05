using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageURL", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Fireplace, Hiking trails, Sauna", new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4196), "Escape to the tranquility of this luxurious villa nestled in the mountains.", "https://example.com/villa2_image.jpg", "Mountain Retreat Villa", 6, 4.7000000000000002, 3500, new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4206) },
                    { 2, "Private beach access, Outdoor dining area, Spa", new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4208), "Experience the ultimate beachfront getaway in this stunning villa.", "https://example.com/villa1_image.jpg", "Beach View", 10, 4.5, 4500, new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4209) },
                    { 3, "Swimming pool, Jacuzzi, Gym, BBQ area", new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4210), "This exquisite villa offers stunning views and luxurious amenities.", "https://example.com/villa_image.jpg", "Luxury Villa", 8, 5.0, 5000, new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4211) },
                    { 4, "Hot tub, Nature trails, Outdoor seating area", new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4212), "Experience privacy and serenity in this secluded villa surrounded by nature.", "https://example.com/villa4_image.jpg", "Secluded Villa in the Woods", 4, 4.0, 3000, new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4213) },
                    { 5, "Infinity pool, Home theater, Outdoor lounge area", new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4215), "Indulge in modern elegance and relax by the private pool in this stylish villa.", "https://example.com/villa3_image.jpg", "Modern Villa with Pool", 8, 4.2000000000000002, 4000, new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4215) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
