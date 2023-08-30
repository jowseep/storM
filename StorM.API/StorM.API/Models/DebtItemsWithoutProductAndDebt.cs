using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorM.API.Models
{
    public class DebtItemsWithoutProductAndDebt
    {
        public int ProductId { get; set; }
        public byte Qty { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal PriceAtBorrowed { get; set; }
    }
}
