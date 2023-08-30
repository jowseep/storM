using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class DebtItemRepository : GenericRepository<DebtItem>, IDebtItemRepository
    {
        private readonly StoreInfoContext _storeInfoContext;
        public DebtItemRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
            _storeInfoContext = storeInfoContext;
        }

        public Task<IQueryable<ProductWithoutDebtItemsAndStore>> GetDebtItemsWithDebtId(int id)
        {
            var debtItems = (from d in _storeInfoContext.Debts
                             join di in _storeInfoContext.DebtItems on d.Id equals di.Id
                             join p in _storeInfoContext.Products on di.Id equals p.Id
                             where di.DebtId == id
                             select new ProductWithoutDebtItemsAndStore
                             {
                                 Id = d.Id,
                                 Name = p.Name,
                                 Price = di.PriceAtBorrowed
                             });

            return Task.FromResult(debtItems);
        }
    }
}
