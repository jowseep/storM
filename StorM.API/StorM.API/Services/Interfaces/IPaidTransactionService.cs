using StorM.API.Models;

namespace StorM.API.Services.Interfaces
{
    public interface IPaidTransactionService : IGenericService<PaidTransactionWithoutPaidDebts, PaidTransaction>
    {
    }
}
