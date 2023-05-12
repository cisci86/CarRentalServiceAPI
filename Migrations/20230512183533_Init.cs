using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalServiceAPI.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.LicensePlateNumber);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleLicensePlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RentalStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentalEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingNumber);
                    table.ForeignKey(
                        name: "FK_Bookings_Vehicles_VehicleLicensePlateNumber",
                        column: x => x.VehicleLicensePlateNumber,
                        principalTable: "Vehicles",
                        principalColumn: "LicensePlateNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "LicensePlateNumber", "Available", "Mileage", "Type" },
                values: new object[,]
                {
                    { "ABC123", true, 213456, "Småbil" },
                    { "JML707", true, 2134567, "Kombi" },
                    { "KHU876", false, 65789, "Kombi" },
                    { "MJD291", true, 6543210, "Lastbil" },
                    { "MPK459", true, 679865, "Småbil" },
                    { "NNE867", true, 238976, "Småbil" },
                    { "PLD982", false, 98624, "Lastbil" },
                    { "UYE987", true, 760898, "Kombi" },
                    { "WWO098", true, 6751099, "Kombi" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "RentalEndTime", "RentalStartTime", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("460b0272-9561-4352-a129-dd4dd55f2e57"), true, "860919-1666", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), "KHU876" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "RentalEndTime", "RentalStartTime", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("908f78ba-2291-496a-aab1-35f136b89305"), true, "440712-5621", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), "PLD982" });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_VehicleLicensePlateNumber",
                table: "Bookings",
                column: "VehicleLicensePlateNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
