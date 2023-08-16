using StorM.API.Models;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class PaidTransactionRepository : IStoreRepository<PaidTransaction>
    {
        public Task Add(PaidTransaction entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaidTransaction>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PaidTransaction?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, PaidTransaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
