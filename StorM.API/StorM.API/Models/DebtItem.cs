using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorM.API.Models
{
    public class DebtItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public int DebtId { get; set; }
        public Debt Debt { get; set; } = new Debt();
        public byte Qty { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal PriceAtBorrowed { get; set; }
    }
}
