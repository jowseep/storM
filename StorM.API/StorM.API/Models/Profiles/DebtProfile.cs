using AutoMapper;

namespace StorM.API.Models.Profiles
{
    public class DebtProfile : Profile
    {
        public DebtProfile()
        {
            CreateMap<Debt, DebtWithoutDebtItems>();
        }
    }
}
