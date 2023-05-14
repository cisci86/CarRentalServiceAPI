using AutoMapper;
using CarRentalServiceAPI.Models;
using CarRentalServiceAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult<string>> StartRental( RentalStartVM rentalInfo)
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

            //return booking number
            return newRental.BookingNumber.ToString();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetActiveRentals()
        {
            List<string> activeRentals;
            try
            {
              activeRentals = _context.Rentals.Where(r => r.Active).Select(r => r.BookingNumber.ToString()).ToList();
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
                throw;
            }
                

            return Ok(activeRentals);
        }

        [HttpPut]
        public void EndRental()
        {

        }
    }
}
