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

        [HttpGet]
        public void GetVehicles()
        {

        }
    }
}
