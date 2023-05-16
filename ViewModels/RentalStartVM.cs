namespace CarRentalServiceAPI.ViewModels
{
    public class RentalStartVM
    {
        public string VehicleLicensePlateNumber { get; set; }
        public DateTime RentalStartTime { get; set; }
        public string CustomerNumber { get; set; }
        public float StartMileage { get; set; }

    }
}
