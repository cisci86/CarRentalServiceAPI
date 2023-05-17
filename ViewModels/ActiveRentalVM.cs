namespace CarRentalServiceAPI.ViewModels
{
    public class ActiveRentalVM
    {
        public Guid BookingNumber { get; set; }
        public string VehicleLicensePlateNumber { get; set; }
        public DateTime RentalStartTime { get; set; }
        public string CustomerNumber { get; set; }
        public float StartMileage { get; set; }
    }
}
