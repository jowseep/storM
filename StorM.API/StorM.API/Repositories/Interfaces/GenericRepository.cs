using Microsoft.EntityFrameworkCore;
using StorM.API.Repositories.Data;
using System.Reflection;

namespace StorM.API.Repositories.Interfaces
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly StoreInfoContext _context;

        public GenericRepository(StoreInfoContext storeInfoContext)
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

        public async Task Update(int id, T entity)
        {
            var result = await _context.Set<T>().FindAsync(id);

            if (result == null)
            {
                return;
            }

            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach(var property in properties) 
            {
                PropertyInfo? updatedProperty = typeof(T).GetProperty(property.Name);
                property.SetValue(result, updatedProperty?.GetValue(entity));
            }

            await _context.SaveChangesAsync();
        }
    }
}
