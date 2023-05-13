using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalServiceAPI.Migrations
{
    public partial class RenamedBookingToRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("174155ab-6bad-4984-ac39-d77729dc1c3d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("ee87348c-0995-43e6-98b6-b54d152ab2cd"));

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("4ee5a9c6-cd28-4c91-b190-fb3b42c9bdae"), true, "440712-5621", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 5689421, "PLD982" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("5fd23005-578c-445c-ad37-21dd39c3647e"), true, "860919-1666", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), 230148, "KHU876" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("4ee5a9c6-cd28-4c91-b190-fb3b42c9bdae"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("5fd23005-578c-445c-ad37-21dd39c3647e"));

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("174155ab-6bad-4984-ac39-d77729dc1c3d"), true, "440712-5621", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 5689421, "PLD982" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("ee87348c-0995-43e6-98b6-b54d152ab2cd"), true, "860919-1666", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), 230148, "KHU876" });
        }
    }
}
