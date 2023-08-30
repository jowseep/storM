using StorM.API.Models;

namespace StorM.API.Repositories.Interfaces
{
    public interface IDebtRepository : IGenericRepository<Debt>
    {
        public Task<IEnumerable<Debt>> GetDebtByBorrowerId(int id);
        public Task<int> AddDebtWithDebtItems(int id, decimal total, DateTime date, List<DebtItemsWithoutProductAndDebt> debtItems);
    }
}
