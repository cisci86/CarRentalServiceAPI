using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalServiceAPI.Migrations
{
    public partial class RemovedMileageFromVehicleAndAddedStartAndEndMileageToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("1b0acbe9-8c5c-47b7-93dc-3ad7809fcc2b"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("1dad719a-a576-44cc-a8c2-d91df6a350ba"));

            migrationBuilder.DropColumn(
                name: "Mileage",
                table: "Vehicles");

            migrationBuilder.AddColumn<int>(
                name: "EndMileage",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StartMileage",
                table: "Bookings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("174155ab-6bad-4984-ac39-d77729dc1c3d"), true, "440712-5621", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 5689421, "PLD982" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("ee87348c-0995-43e6-98b6-b54d152ab2cd"), true, "860919-1666", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), 230148, "KHU876" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("174155ab-6bad-4984-ac39-d77729dc1c3d"));

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingNumber",
                keyValue: new Guid("ee87348c-0995-43e6-98b6-b54d152ab2cd"));

            migrationBuilder.DropColumn(
                name: "EndMileage",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "StartMileage",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "Mileage",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "RentalEndTime", "RentalStartTime", "VehicleLicensePlateNumber" },
                values: new object[,]
                {
                    { new Guid("1b0acbe9-8c5c-47b7-93dc-3ad7809fcc2b"), true, "440712-5621", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "PLD982" },
                    { new Guid("1dad719a-a576-44cc-a8c2-d91df6a350ba"), true, "860919-1666", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), "KHU876" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "ABC123",
                column: "Mileage",
                value: 213456);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "JML707",
                column: "Mileage",
                value: 2134567);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "KHU876",
                column: "Mileage",
                value: 65789);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "MJD291",
                column: "Mileage",
                value: 6543210);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "MPK459",
                column: "Mileage",
                value: 679865);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "NNE867",
                column: "Mileage",
                value: 238976);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "PLD982",
                column: "Mileage",
                value: 98624);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "UYE987",
                column: "Mileage",
                value: 760898);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "LicensePlateNumber",
                keyValue: "WWO098",
                column: "Mileage",
                value: 6751099);
        }
    }
}
