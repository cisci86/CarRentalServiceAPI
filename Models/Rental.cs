﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalServiceAPI.Models
{
    public class Rental
    {
        [Key]
        public Guid BookingNumber { get; set; } =  Guid.NewGuid();
        public string VehicleLicensePlateNumber { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime RentalStartTime { get; set; }
        public DateTime RentalEndTime { get; set; }
        public string CustomerNumber { get; set; }
        public bool Active { get; set; }
        public int StartMileage { get; set; }
        public int EndMileage { get; set; }
    }
}
