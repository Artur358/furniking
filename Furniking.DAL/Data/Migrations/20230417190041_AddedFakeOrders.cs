using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Furniking.DAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFakeOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b616c486-2b7b-4441-8dbd-0096b713a25b", "AQAAAAIAAYagAAAAEBfR7TYeWK3iPouKuPHdmpubv74fbRO9/SQDHpibpovHym8bWDXMhpfnP2OzyZG6XQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f77b1390-1010-4d2f-95cd-63ae918eaff0", "AQAAAAIAAYagAAAAEA3QY8+YreyiJ/ZbgX1cT7IsIsWLI7ZJliD/+LASffMnWGBdB7CYTF0/tv+wbQacXQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bceb58e-71e1-407f-9488-f9442de38ba9", "AQAAAAIAAYagAAAAEEwet+opf8YtQYfS/kdFjmRAIaRwapGqdKvxY0OqUVRrXj6qaMUfzr9tNIUtO7wYOA==" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Count", "DateOfOrder", "FurnitureId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 19, 4, 11, 55, 228, DateTimeKind.Unspecified).AddTicks(5825), 26, 3 },
                    { 2, 4, new DateTime(2023, 4, 11, 15, 31, 2, 526, DateTimeKind.Unspecified).AddTicks(6767), 37, 1 },
                    { 3, 2, new DateTime(2023, 4, 1, 16, 28, 3, 393, DateTimeKind.Unspecified).AddTicks(1365), 20, 1 },
                    { 4, 2, new DateTime(2023, 3, 17, 15, 28, 59, 874, DateTimeKind.Unspecified).AddTicks(1132), 38, 1 },
                    { 5, 1, new DateTime(2023, 4, 13, 11, 57, 26, 773, DateTimeKind.Unspecified).AddTicks(2913), 18, 3 },
                    { 6, 1, new DateTime(2023, 4, 2, 10, 0, 35, 245, DateTimeKind.Unspecified).AddTicks(3564), 36, 2 },
                    { 7, 3, new DateTime(2023, 4, 5, 5, 41, 16, 627, DateTimeKind.Unspecified).AddTicks(3057), 38, 3 },
                    { 8, 2, new DateTime(2023, 3, 24, 14, 28, 16, 991, DateTimeKind.Unspecified).AddTicks(3561), 11, 3 },
                    { 9, 3, new DateTime(2023, 4, 1, 1, 7, 51, 160, DateTimeKind.Unspecified).AddTicks(9815), 39, 1 },
                    { 10, 1, new DateTime(2023, 4, 1, 0, 1, 50, 206, DateTimeKind.Unspecified).AddTicks(8857), 25, 2 },
                    { 11, 4, new DateTime(2023, 3, 30, 23, 43, 41, 908, DateTimeKind.Unspecified).AddTicks(9056), 15, 1 },
                    { 12, 4, new DateTime(2023, 3, 26, 3, 18, 55, 125, DateTimeKind.Unspecified).AddTicks(7335), 43, 2 },
                    { 13, 1, new DateTime(2023, 4, 12, 10, 2, 13, 974, DateTimeKind.Unspecified).AddTicks(2114), 31, 2 },
                    { 14, 3, new DateTime(2023, 4, 1, 9, 32, 32, 824, DateTimeKind.Unspecified).AddTicks(4670), 27, 1 },
                    { 15, 4, new DateTime(2023, 3, 19, 2, 2, 28, 257, DateTimeKind.Unspecified).AddTicks(1889), 9, 3 },
                    { 16, 1, new DateTime(2023, 3, 29, 23, 2, 54, 906, DateTimeKind.Unspecified).AddTicks(5666), 1, 2 },
                    { 17, 5, new DateTime(2023, 3, 17, 14, 40, 38, 212, DateTimeKind.Unspecified).AddTicks(5221), 37, 3 },
                    { 18, 4, new DateTime(2023, 3, 28, 6, 51, 24, 250, DateTimeKind.Unspecified).AddTicks(8342), 36, 3 },
                    { 19, 3, new DateTime(2023, 3, 28, 14, 43, 56, 276, DateTimeKind.Unspecified).AddTicks(7467), 33, 2 },
                    { 20, 2, new DateTime(2023, 3, 19, 8, 19, 53, 724, DateTimeKind.Unspecified).AddTicks(7938), 15, 1 },
                    { 21, 2, new DateTime(2023, 4, 13, 6, 34, 59, 54, DateTimeKind.Unspecified).AddTicks(2060), 28, 2 },
                    { 22, 4, new DateTime(2023, 3, 19, 4, 27, 38, 424, DateTimeKind.Unspecified).AddTicks(1912), 2, 3 },
                    { 23, 3, new DateTime(2023, 4, 8, 4, 26, 14, 380, DateTimeKind.Unspecified).AddTicks(2294), 47, 1 },
                    { 24, 3, new DateTime(2023, 3, 25, 9, 38, 8, 363, DateTimeKind.Unspecified).AddTicks(7858), 15, 2 },
                    { 25, 1, new DateTime(2023, 3, 24, 21, 42, 53, 872, DateTimeKind.Unspecified).AddTicks(8187), 31, 2 },
                    { 26, 3, new DateTime(2023, 4, 5, 19, 22, 27, 465, DateTimeKind.Unspecified).AddTicks(7339), 41, 1 },
                    { 27, 1, new DateTime(2023, 4, 14, 22, 16, 57, 585, DateTimeKind.Unspecified).AddTicks(9348), 4, 1 },
                    { 28, 5, new DateTime(2023, 3, 28, 16, 58, 15, 83, DateTimeKind.Unspecified).AddTicks(893), 32, 1 },
                    { 29, 5, new DateTime(2023, 4, 5, 23, 51, 22, 963, DateTimeKind.Unspecified).AddTicks(6571), 11, 3 },
                    { 30, 5, new DateTime(2023, 4, 10, 16, 5, 48, 554, DateTimeKind.Unspecified).AddTicks(1077), 38, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21c53e03-fd40-4570-90c8-211429dee3b3", "AQAAAAIAAYagAAAAEHoWCBgH3ws4pJuPE0Sw0nXGaaSaUaWQ0xd8iGVtU0PpUSaU3sx1hunMzugJILO0jQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ee75aeac-5629-48db-a34a-5c97a0e31e8e", "AQAAAAIAAYagAAAAEJQpYDRw6wDN0DFD2TfMXlotvG2nRWUCsR08Cknx8POGd7SHqrQm4mXsgXfWG5aJ8w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f0f8c806-61be-474a-84d5-9a241eb02cfb", "AQAAAAIAAYagAAAAEDOSM01nsK/lzdlCNusop15wuaNEMqiwhVI0HEF/Pil67OgMe4eD3ouRPeulfi5IeA==" });
        }
    }
}
