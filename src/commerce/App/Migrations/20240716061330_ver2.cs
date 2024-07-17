using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    /// <inheritdoc />
    public partial class ver2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Email);
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9227), new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9229), new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9230), new DateTime(2024, 7, 16, 13, 13, 29, 630, DateTimeKind.Local).AddTicks(9231) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(770), new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(790), new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(790) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(793), new DateTime(2024, 7, 16, 13, 11, 46, 773, DateTimeKind.Local).AddTicks(793) });
        }
    }
}
