using AutoMapper;

namespace StorM.API.Models.Profiles
{
    public class BorrowerProfile : Profile
    {
        public BorrowerProfile()
        {
            CreateMap<Borrower, BorrowerWithoutDebtsAndPaidTransactions>();
        }
    }
}
