using System.ComponentModel.DataAnnotations;

namespace StorM.API.Models
{
    public class BorrowerWithoutDebtsAndPaidTransactions
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }
}
