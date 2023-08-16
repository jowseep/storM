namespace StorM.API.Services.Interfaces
{
    public interface IStoreService<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(int id);
    }
}
