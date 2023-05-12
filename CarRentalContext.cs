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

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Vehicle seed
            modelBuilder.Entity<Vehicle>()
                .HasData(
                    new Vehicle { Type = "Småbil", LicensePlateNumber = "ABC123", Available = true, Mileage = 213456 },
                    new Vehicle { Type = "Småbil", LicensePlateNumber = "MPK459", Available = true, Mileage = 679865 },
                    new Vehicle { Type = "Småbil", LicensePlateNumber = "NNE867", Available = true, Mileage = 238976 },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "JML707", Available = true, Mileage = 2134567 },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "KHU876", Available = false, Mileage = 65789 },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "UYE987", Available = true, Mileage = 760898 },
                    new Vehicle { Type = "Kombi", LicensePlateNumber = "WWO098", Available = true, Mileage = 6751099 },
                    new Vehicle { Type = "Lastbil", LicensePlateNumber = "PLD982", Available = false, Mileage = 98624 },
                    new Vehicle { Type = "Lastbil", LicensePlateNumber = "MJD291", Available = true, Mileage = 6543210 }
                );
            
            
            //Booking seed
            modelBuilder.Entity<Booking>()
                .HasData(
                    new Booking { RentalStartTime = new DateTime(2023, 05, 12, 08, 15, 00), Active = true, CustomerNumber = "860919-1666", VehicleLicensePlateNumber = "KHU876" },
                    new Booking { RentalStartTime = new DateTime(2023, 05, 11, 20, 00, 00), Active = true, CustomerNumber = "440712-5621", VehicleLicensePlateNumber = "PLD982" }
                );
        }
    }
}
