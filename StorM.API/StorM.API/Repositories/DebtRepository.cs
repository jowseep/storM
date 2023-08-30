using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;
using System.Data;

namespace StorM.API.Repositories
{
    public class DebtRepository : GenericRepository<Debt>, IDebtRepository
    {
        private readonly StoreInfoContext _storeInfoContext;
        public DebtRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
            _storeInfoContext = storeInfoContext;
        }

        public async Task<int> AddDebtWithDebtItems(int id, decimal total, DateTime date, List<DebtItemsWithoutProductAndDebt> debtItems)
        {
            var dt = new DataTable();
            dt.Columns.Add("ProductId", typeof(int));
            dt.Columns.Add("Qty", typeof(byte));
            dt.Columns.Add("PriceAtBorrowed", typeof (decimal));

            foreach (var debtItem in debtItems)
            {
                dt.Rows.Add(debtItem.ProductId, debtItem.Qty, debtItem.PriceAtBorrowed);
            }

            var parameters = new[]
            {
                new SqlParameter("@BorrowerId", SqlDbType.Int) { Value = id },
                new SqlParameter("@Total", SqlDbType.Decimal) { Value = total },
                new SqlParameter("@Date", SqlDbType.DateTime2) { Value = date },
                new SqlParameter("@DebtItems", SqlDbType.Structured)
                {
                    Value = dt,
                    TypeName = "dbo.DebtItemsTableType"
                }
            };

            var query = "exec InsertDebtWithItems @BorrowerId, @Total, @Date, @DebtItems";
            var affectedRows = await _storeInfoContext.Database.ExecuteSqlRawAsync(query, parameters);

            return affectedRows;
        }

        public async Task<IEnumerable<Debt>> GetDebtByBorrowerId(int id)
        {
            return await _storeInfoContext.Debts
                .Where(x => x.BorrowerId == id)
                .ToListAsync();
        }
    }
}
