using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalServiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingController : ControllerBase
    {
        [HttpGet]
        public void GetBooking()
        {

        }
        [HttpPost]
        public void StartRental()
        {

        }
    }
}
