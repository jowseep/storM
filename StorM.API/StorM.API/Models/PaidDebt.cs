namespace StorM.API.Models
{
    public class PaidDebt
    {
        public int Id { get; set; }
        public int PaidTransactionId { get; set; }
        public PaidTransaction PaidTransaction { get; set; } = new PaidTransaction();
        public int DebtId { get; set; }
        public Debt Debt { get; set; } = new Debt();
    }
}
