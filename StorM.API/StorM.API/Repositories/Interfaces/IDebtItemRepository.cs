using StorM.API.Models;

namespace StorM.API.Repositories.Interfaces
{
    public interface IDebtItemRepository : IGenericRepository<DebtItem>
    {
        public Task<IQueryable<ProductWithoutDebtItemsAndStore>> GetDebtItemsWithDebtId(int id);
    }
}
