namespace CarRentalServiceAPI.ViewModels
{
    public class BookingStartVM
    {
        public string VehicleLicensePlateNumber { get; set; }
        public DateTime RentalStart { get; set; }
        public string CustomerNumber { get; set; }
        public int StartMileage { get; set; }

    }
}
