using StorM.API.Models;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class DebtRepository : IStoreRepository<Debt>
    {
        public Task Add(Debt entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Debt>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Debt?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Debt entity)
        {
            throw new NotImplementedException();
        }
    }
}
