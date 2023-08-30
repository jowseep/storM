namespace StorM.API.Services.Interfaces
{
    public interface IGenericService<T, U>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T?> GetById(int id);

        public Task Add(U entity);
        public Task Update(int id, U entity);
    }
}
