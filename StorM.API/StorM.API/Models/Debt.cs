using System.ComponentModel.DataAnnotations.Schema;

namespace StorM.API.Models
{
    public class Debt
    {
        public int Id { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; } = new Borrower();
        [Column(TypeName = "decimal(6,2)")]
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName="decimal(6,2)")]
        public decimal Balance { get; set; }
        public ICollection<DebtItem> DebtItems { get; set; } = new List<DebtItem>();
    }
}
