using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class PaidTransactionService : GenericService<PaidTransactionWithoutPaidDebts, PaidTransaction>, IPaidTransactionService
    {
        public PaidTransactionService(IPaidTransactionRepository repository, IMapper imapper) : base(repository, imapper)
        {
        }
    }
}
