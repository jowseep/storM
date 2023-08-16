namespace StorM.API.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public ICollection<Debt> Debts { get; set; } = new List<Debt>();
        public ICollection<PaidTransaction> PaidTransactions { get; set; } = new List<PaidTransaction>();

    }
}
 