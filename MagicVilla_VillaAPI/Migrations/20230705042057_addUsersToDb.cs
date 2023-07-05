using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8943), new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8956) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8958), new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8960), new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8962), new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8963) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8964), new DateTime(2023, 7, 5, 11, 20, 57, 29, DateTimeKind.Local).AddTicks(8965) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4196), new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4208), new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4210), new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4212), new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4213) });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4215), new DateTime(2023, 7, 5, 9, 36, 8, 358, DateTimeKind.Local).AddTicks(4215) });
        }
    }
}
