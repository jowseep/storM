using AutoMapper;

namespace StorM.API.Models.Profiles
{
    public class DebtItemProfile : Profile
    {
        public DebtItemProfile() 
        {
            CreateMap<DebtItem, DebtItemsWithoutProductAndDebt>();
        }
    }
}
