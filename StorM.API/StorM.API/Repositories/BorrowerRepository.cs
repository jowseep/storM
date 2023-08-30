using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class BorrowerRepository : GenericRepository<Borrower>, IBorrowerRepository
    {
        public BorrowerRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
        }
    }
}
