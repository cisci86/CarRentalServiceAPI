using CarRentalServiceAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly CarRentalContext _context;
        public VehicleController(CarRentalContext context)
        {

            _context = context;
        }

        [HttpGet("{vehicleType}")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles(string vehicleType)
        {
            List<Vehicle> vehicles;
            try
            {
                 vehicles = _context.Vehicles.Where(v => v.Type == vehicleType).ToList();

            }
            catch (Exception ex)
            {

                return StatusCode(500, new { Message = ex.Message });
            }

            return Ok(vehicles);
        }
    }
}
