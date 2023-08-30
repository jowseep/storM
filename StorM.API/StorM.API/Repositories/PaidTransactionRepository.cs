using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class PaidTransactionRepository : GenericRepository<PaidTransaction>, IPaidTransactionRepository
    {
        public PaidTransactionRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
        }
    }
}
