using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalServiceAPI.Migrations
{
    public partial class changedMileageToFloat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "BookingNumber",
                keyValue: new Guid("779b27c3-1f2b-4f3a-b4cb-9315d29d0918"));

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "BookingNumber",
                keyValue: new Guid("f364ed32-9df9-42c1-937b-7bd366bd1f27"));

            migrationBuilder.AlterColumn<float>(
                name: "StartMileage",
                table: "Rentals",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "EndMileage",
                table: "Rentals",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("0efe1892-c700-403f-bd28-b9d5cb2a2258"), true, "440712-5621", 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 5689421f, "PLD982" });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("e82e9721-7144-4232-97ac-57a4d087208d"), true, "860919-1666", 0f, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), 230148f, "KHU876" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "BookingNumber",
                keyValue: new Guid("0efe1892-c700-403f-bd28-b9d5cb2a2258"));

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "BookingNumber",
                keyValue: new Guid("e82e9721-7144-4232-97ac-57a4d087208d"));

            migrationBuilder.AlterColumn<int>(
                name: "StartMileage",
                table: "Rentals",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "EndMileage",
                table: "Rentals",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("779b27c3-1f2b-4f3a-b4cb-9315d29d0918"), true, "860919-1666", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), 230148, "KHU876" });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("f364ed32-9df9-42c1-937b-7bd366bd1f27"), true, "440712-5621", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 5689421, "PLD982" });
        }
    }
}
