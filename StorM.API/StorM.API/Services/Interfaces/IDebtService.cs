using StorM.API.Models;

namespace StorM.API.Services.Interfaces
{
    public interface IDebtService : IGenericService<DebtWithoutDebtItems, Debt>
    {
        public Task<IEnumerable<DebtWithoutDebtItems>> GetDebtByBorrowerId(int id);
        public Task<int> AddDebtWithDebtItems(int id, decimal total, DateTime date, List<DebtItemsWithoutProductAndDebt> debtItems);
    }
}
