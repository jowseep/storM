using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class PaidDebtService : GenericService<PaidDebt, PaidDebt>, IPaidDebtService
    {
        public PaidDebtService(IPaidDebtRepository repository, IMapper imapper) : base(repository, imapper)
        {
        }
    }
}
