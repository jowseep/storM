using AutoMapper;

namespace StorM.API.Models.Profiles
{
    public class PaidTransactionProfile : Profile
    {
        public PaidTransactionProfile()
        {
            CreateMap<PaidTransaction, PaidTransactionWithoutPaidDebts>();
        }
    }
}
