using AutoMapper;
using CarRentalServiceAPI.Models;
using CarRentalServiceAPI.ViewModels;

namespace CarRentalServiceAPI.AutoMapper
{
    public class RentalProfile: Profile
    {
        public RentalProfile() {
            CreateMap<RentalStartVM, Rental>()
                .BeforeMap((s, d) => d.Active = true);
            CreateMap<Rental, ActiveRentalVM>();
        }
    }
}
