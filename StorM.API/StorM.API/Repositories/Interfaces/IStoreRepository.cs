using StorM.API.Models;

namespace StorM.API.Repositories.Interfaces
{
    public interface IStoreRepository : IGenericRepository<Store>
    {
        public Task<IQueryable<Borrower>> GetBorrowersByStoreId(int id);
    }
}
