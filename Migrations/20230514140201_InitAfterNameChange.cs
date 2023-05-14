using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRentalServiceAPI.Migrations
{
    public partial class InitAfterNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.LicensePlateNumber);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    BookingNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VehicleLicensePlateNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RentalStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentalEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    StartMileage = table.Column<int>(type: "int", nullable: false),
                    EndMileage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.BookingNumber);
                    table.ForeignKey(
                        name: "FK_Rentals_Vehicles_VehicleLicensePlateNumber",
                        column: x => x.VehicleLicensePlateNumber,
                        principalTable: "Vehicles",
                        principalColumn: "LicensePlateNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "LicensePlateNumber", "Available", "Type" },
                values: new object[,]
                {
                    { "ABC123", true, "Småbil" },
                    { "JML707", true, "Kombi" },
                    { "KHU876", false, "Kombi" },
                    { "MJD291", true, "Lastbil" },
                    { "MPK459", true, "Småbil" },
                    { "NNE867", true, "Småbil" },
                    { "PLD982", false, "Lastbil" },
                    { "UYE987", true, "Kombi" },
                    { "WWO098", true, "Kombi" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("779b27c3-1f2b-4f3a-b4cb-9315d29d0918"), true, "860919-1666", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 12, 8, 15, 0, 0, DateTimeKind.Unspecified), 230148, "KHU876" });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "BookingNumber", "Active", "CustomerNumber", "EndMileage", "RentalEndTime", "RentalStartTime", "StartMileage", "VehicleLicensePlateNumber" },
                values: new object[] { new Guid("f364ed32-9df9-42c1-937b-7bd366bd1f27"), true, "440712-5621", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 11, 20, 0, 0, 0, DateTimeKind.Unspecified), 5689421, "PLD982" });

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_VehicleLicensePlateNumber",
                table: "Rentals",
                column: "VehicleLicensePlateNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
