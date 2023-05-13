using CarRentalServiceAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingController : ControllerBase
    {
        private readonly CarRentalContext _context;
        public BookingController(CarRentalContext context)
        {
            _context = context;
        }
        [HttpPatch]
        public void EndRental()
        {

        }
        [HttpPost]
        public void StartRental( BookingStartVM bookingInfo)
        {
            
        }
    }
}
