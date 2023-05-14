namespace CarRentalServiceAPI.ViewModels
{
    public class RentalEndVM
    {
        public Guid BookingNumber { get; set; }
        public DateTime RentalEndTime { get; set; }
        public float EndMileage { get; set; }
    }
}
