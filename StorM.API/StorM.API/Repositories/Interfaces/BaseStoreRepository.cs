using Microsoft.EntityFrameworkCore;
using StorM.API.Repositories.Data;

namespace StorM.API.Repositories.Interfaces
{
    public abstract class BaseStoreRepository<T> : IStoreRepository<T> where T : class
    {
        private readonly StoreInfoContext _context;

        public BaseStoreRepository(StoreInfoContext storeInfoContext)
        {
            _context = storeInfoContext;
        }
        public async Task Add(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);

            if(result == null)
            {
                return null;
            }

            return result;
        }
    }
}
