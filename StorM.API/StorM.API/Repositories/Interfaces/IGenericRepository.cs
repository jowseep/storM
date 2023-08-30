namespace StorM.API.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(int id);
        public Task Add(T entity);
        public Task Update(int id, T entity);
    }
}
