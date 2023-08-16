using StorM.API.Models;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class DebtItemRepository : IStoreRepository<DebtItem>
    {
        public Task Add(DebtItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DebtItem>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<DebtItem?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, DebtItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
