using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class StoreService : GenericService<StoreClientDetails, Store>, IStoreService
    {
        private readonly IStoreRepository _repository;
        private readonly IMapper _mapper;
        public StoreService(IStoreRepository repository, IMapper imapper) : base(repository, imapper)
        {
            _repository = repository;
            _mapper = imapper;
        }

        public async Task<IEnumerable<BorrowerWithoutDebtsAndPaidTransactions>> GetBorrowersByStoreId(int id)
        {
            var borrowers = await _repository.GetBorrowersByStoreId(id);
            return _mapper.Map<IEnumerable<BorrowerWithoutDebtsAndPaidTransactions>>(borrowers);
        }
    }
}
