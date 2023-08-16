using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StorM.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set;  } = string.Empty;
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; } = new Store();
        
        public ICollection<DebtItem> DebtItems { get; set; } = new List<DebtItem>();
    }
}
