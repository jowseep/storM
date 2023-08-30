using StorM.API.Models;

namespace StorM.API.Services.Interfaces
{
    public interface IProductService : IGenericService<ProductWithoutDebtItemsAndStore, Product>
    {
    }
}
