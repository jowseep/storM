using StorM.API.Models;

namespace StorM.API.Services.Interfaces
{
    public interface IStoreService : IGenericService<StoreClientDetails, Store>
    {
        public Task<IEnumerable<BorrowerWithoutDebtsAndPaidTransactions>> GetBorrowersByStoreId(int id);
    }
}
