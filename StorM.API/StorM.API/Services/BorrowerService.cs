using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class BorrowerService : GenericService<BorrowerWithoutDebtsAndPaidTransactions, Borrower>, IBorrowerService
    {
        public BorrowerService(IBorrowerRepository repository, IMapper imapper) : base(repository, imapper)
        {
        }
    }
}
