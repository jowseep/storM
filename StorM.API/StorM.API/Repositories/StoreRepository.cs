using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        private readonly StoreInfoContext _context;
        public StoreRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
            _context = storeInfoContext;
        }

        public Task<IQueryable<Borrower>> GetBorrowersByStoreId(int id)
        {
            var borrowers = (from b in _context.Borrowers
                            join d in _context.Debts on b.Id equals d.BorrowerId
                            join di in _context.DebtItems on d.Id equals di.DebtId
                            join p in _context.Products on di.ProductId equals p.Id
                            where p.Id == id
                            select b).Distinct();

            return Task.FromResult(borrowers);
        }
    }
}
