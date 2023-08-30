using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
        }
    }
}
