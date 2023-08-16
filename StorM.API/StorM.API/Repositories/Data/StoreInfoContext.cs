using Microsoft.EntityFrameworkCore;
using StorM.API.Models;

namespace StorM.API.Repositories.Data
{
    public class StoreInfoContext : DbContext
    {
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Borrower> Borrowers { get; set; }
        public DbSet<Debt> Debts { get; set; }
        public DbSet<DebtItem> DebtItems { get; set; }
        public DbSet<PaidTransaction> PaidTransactions { get; set; }
        public DbSet<PaidDebt> PaidDebts { get; set; }

        public StoreInfoContext(DbContextOptions options) : base(options)
        {
        }
    }
}
