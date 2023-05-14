using CarRentalServiceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalServiceAPI
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext(DbContextOptions<CarRentalContext> options)
        : base(options)
        {
        }

        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Vehicle seed
            modelBuilder.Entity<Vehicle>()
                .HasData(
                    new Vehicle { Type = "Småbil", LicensePlateNumber = "ABC123", Available = true },
                    new Vehicle { Type = "Småbil", LicensePlateNumber = "MPK459", Available = true  },
                    new Vehicle { Type = "Småbil", LicensePlateNumber = "NNE867", Available = true },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "JML707", Available = true },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "KHU876", Available = false },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "UYE987", Available = true },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "WWO098", Available = true },
                    new Vehicle { Type = "Lastbil", LicensePlateNumber = "PLD982", Available = false },
                    new Vehicle { Type = "Lastbil", LicensePlateNumber = "MJD291", Available = true }
                );
            
            
            //Booking seed
            modelBuilder.Entity<Rental>()
                .HasData(
                    new Rental { RentalStartTime = new DateTime(2023, 05, 12, 08, 15, 00), Active = true, CustomerNumber = "860919-1666", VehicleLicensePlateNumber = "KHU876", StartMileage = 230148 },
                    new Rental { RentalStartTime = new DateTime(2023, 05, 11, 20, 00, 00), Active = true, CustomerNumber = "440712-5621", VehicleLicensePlateNumber = "PLD982", StartMileage = 5689421 }
                );
        }
    }
}
