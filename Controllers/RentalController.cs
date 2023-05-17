using AutoMapper;
using CarRentalServiceAPI.Models;
using CarRentalServiceAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RentalController : ControllerBase
    {
        private readonly CarRentalContext _context;
        private readonly IMapper _mapper;
        public RentalController(CarRentalContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> StartRental(RentalStartVM rentalInfo)
        {
            //mapp view model to Rental model
            var newRental = _mapper.Map<Rental>(rentalInfo);

            //Add new Rental to db
            _context.Add(newRental);

            //set rented car as unavailable
            var rentedCar = _context.Vehicles.Where(v => v.LicensePlateNumber == rentalInfo.VehicleLicensePlateNumber).FirstOrDefault();
            if (rentedCar != null)
            {
                rentedCar.Available = false;
            }

            //save changes in db
            await _context.SaveChangesAsync();
            
            //return booking number n
            return Ok(new { bookingnumber = newRental.BookingNumber.ToString() });
        }

        [HttpGet]
        public async Task<ActionResult> GetActiveRentals()
        {
            List<ActiveRentalVM> activeRentals = new List<ActiveRentalVM>();
            try
            {
               var rentals = _context.Rentals.Where(r => r.Active).ToList();
                foreach (var item in rentals)
                {
                    activeRentals.Add(_mapper.Map<ActiveRentalVM>(item));
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }


            return Ok(activeRentals);
        }

        [HttpPut]
        public async Task<ActionResult<double>> EndRental(RentalEndVM rentalEndInfo)
        {
            double totalCost = 0;
            try
            {
                //get the started rental from db
                var rental = _context.Rentals.Include(r => r.Vehicle).Where(r => r.BookingNumber == rentalEndInfo.BookingNumber).FirstOrDefault();
                //calculate rental time
                double daysRented = Math.Round(CalculateDaysRented(rental.RentalStartTime, rentalEndInfo.RentalEndTime), 2);
                //calculate used mileage
                float usedMileage = CalculateUsedMileage(rental.StartMileage, rentalEndInfo.EndMileage);
                //calculate total cost
                totalCost = CalculatePrice(daysRented, usedMileage, rental.Vehicle.Type);

                //update rental in db
                rental.RentalEndTime = rentalEndInfo.RentalEndTime;
                rental.EndMileage = rentalEndInfo.EndMileage;
                rental.Active = false;

                //update vehicle to avalabe
                rental.Vehicle.Available = true;

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
            //returning the cost of rental
            return Ok(new { totalRentalPrice =  Math.Round(totalCost, 1) });
        }

        private double CalculateDaysRented(DateTime startTime, DateTime endTime)
        {
            var daysRented = endTime - startTime;

            return daysRented.TotalDays;
        }

        private float CalculateUsedMileage(float startMileage, float endMileage)
        {
            //calculating used mileage in km
            return (endMileage - startMileage)/1000;
        }

        private double CalculatePrice(double daysRented, float usedMileage, string vehicleType)
        {
            double totalCost;

            //calculate price for small car
            if (vehicleType == "Småbil")
            {
                totalCost = 650 * daysRented;
            }
            //calculate price for combi
            else if (vehicleType == "Kombi")
            {
                totalCost = 650 * daysRented * 1.3 + (18.5 * usedMileage);
            }
            //calculate cost for truck
            else if (vehicleType == "Lastbil")
            {
                totalCost = 650 * daysRented * 1.5 + (18.5 * usedMileage * 1.5);
            }
            else
            {
                totalCost = 0;
            }
            //return total cost 
            return totalCost;
        }
    }
}
