using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorM.API.Models
{
    public class DebtWithoutDebtItems
    {
        public int Id { get; set; }
        //public int BorrowerId { get; set; }
        //public Borrower Borrower { get; set; } = new Borrower();
        [Column(TypeName = "decimal(6,2)")]
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        //I will try to remove balance 08/30
        //[Column(TypeName = "decimal(6,2)")]
        //public decimal Balance { get; set; }
    }
}
