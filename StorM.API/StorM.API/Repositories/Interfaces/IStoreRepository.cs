namespace StorM.API.Repositories.Interfaces
{
    public interface IStoreRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(int id);
        public Task Add(T entity);
    }
}
