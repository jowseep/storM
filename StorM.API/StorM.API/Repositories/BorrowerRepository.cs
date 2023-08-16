using StorM.API.Models;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class BorrowerRepository : IStoreRepository<Borrower>
    {
        public Task Add(Borrower entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Borrower>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Borrower?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Borrower entity)
        {
            throw new NotImplementedException();
        }
    }
}
