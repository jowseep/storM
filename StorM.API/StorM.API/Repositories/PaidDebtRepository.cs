using StorM.API.Models;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class PaidDebtRepository : IStoreRepository<PaidDebt>
    {
        public Task Add(PaidDebt entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaidDebt>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<PaidDebt?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, PaidDebt entity)
        {
            throw new NotImplementedException();
        }
    }
}
