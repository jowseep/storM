using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class StoreService : IStoreService<StoreClientDetails>
    {
        private readonly StoreRepository _repository;
        private readonly IMapper _mapper;

        public StoreService(StoreRepository repository, IMapper imapper)
        {
            _repository = repository;
            _mapper = imapper;
        }

        public async Task<IEnumerable<StoreClientDetails>> GetAll()
        {
            var stores = await _repository.GetAll();
            return _mapper.Map<IEnumerable<StoreClientDetails>>(stores);
        }

        public async Task<StoreClientDetails?> GetById(int id)
        {
            var store = await _repository.GetById(id);

            if (store == null)
            {
                return null;
            }

            return _mapper.Map<StoreClientDetails>(store);
        }

        public async Task Add(Store store)
        {
            await _repository.Add(store);
        }

    }
}
