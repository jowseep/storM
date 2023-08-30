using StorM.API.Models;

namespace StorM.API.Services.Interfaces
{
    public interface IDebtItemService : IGenericService<DebtItem, DebtItem>
    {
        public Task<IEnumerable<ProductWithoutDebtItemsAndStore>> GetDebtItemsWithDebtId(int id);
    }
}
