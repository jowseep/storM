using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class PaidDebtRepository : GenericRepository<PaidDebt>, IPaidDebtRepository
    {
        public PaidDebtRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
        }
    }
}
