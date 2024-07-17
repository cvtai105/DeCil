using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.Migrations
{
    /// <inheritdoc />
    public partial class ver3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Email", "Avatar", "Name", "Password", "Phone" },
                values: new object[] { "admin@gmail.com", null, null, "admin", null });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6922), new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6950), new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6951), new DateTime(2024, 7, 16, 13, 20, 21, 191, DateTimeKind.Local).AddTicks(6951) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Email",
                keyValue: "admin@gmail.com");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Chưa có mô tả");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Chưa có mô tả");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Chưa có mô tả");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Chưa có mô tả");

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
    }
}
