using AutoMapper;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Services.Interfaces
{
    public class GenericService<T, U> : IGenericService<T, U> 
        where T : class
        where U : class
    {

        private readonly IGenericRepository<U> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<U> repository, IMapper imapper)
        {
            _repository = repository;
            _mapper = imapper;
        }
        public async Task Add(U entity)
        {
            await _repository.Add(entity);
            //await _repository.Add(_mapper.Map<U>(entity));
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await _repository.GetAll();
            return _mapper.Map<IEnumerable<T>>(entities);
        }

        public async Task<T?> GetById(int id)
        {
            var entity = await _repository.GetById(id);

            if (entity == null)
            {
                return null;
            }

            return _mapper.Map<T>(entity);
        }

        public async Task Update(int id, U entity)
        {
            await _repository.Update(id, entity);
            //await _repository.Update(id, _mapper.Map<U>(entity));
        }

    }
}
