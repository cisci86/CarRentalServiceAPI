﻿using Microsoft.AspNetCore.Mvc;

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
        [HttpPost]
        public void EndRental()
        {

        }
        [HttpPost]
        public void StartRental()
        {

        }
    }
}
