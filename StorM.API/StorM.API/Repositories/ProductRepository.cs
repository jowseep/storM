using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class ProductRepository : IStoreRepository<Product>
    {

        private readonly StoreInfoContext _storeInfoContext;

        public ProductRepository(StoreInfoContext storeInfoContext)
        {
            _storeInfoContext = storeInfoContext;
        }
        public async Task Add(Product entity)
        {
            await _storeInfoContext.AddAsync(entity);
            await _storeInfoContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _storeInfoContext.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            var product = await _storeInfoContext.Products.FindAsync(id);

            if (product == null)
            {
                return null;
            }

            return product;
        }

    }
}
