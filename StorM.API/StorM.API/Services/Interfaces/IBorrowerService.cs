using StorM.API.Models;

namespace StorM.API.Services.Interfaces
{
    public interface IBorrowerService: IGenericService<BorrowerWithoutDebtsAndPaidTransactions, Borrower>
    {
    }
}
