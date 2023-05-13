

using System.ComponentModel.DataAnnotations;

namespace CarRentalServiceAPI.Models
{
    public class Vehicle
    {
        public string Type { get; set; }
        [Key]
        public string LicensePlateNumber { get; set; }
        public bool Available { get; set; }
    }
}
