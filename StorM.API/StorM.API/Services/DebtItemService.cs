using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class DebtItemService : GenericService<DebtItem, DebtItem>, IDebtItemService
    {
        private readonly IDebtItemRepository _repository;
        public DebtItemService(IDebtItemRepository repository, IMapper imapper) : base(repository, imapper)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductWithoutDebtItemsAndStore>> GetDebtItemsWithDebtId(int id)
        {
            var debtItems = await _repository.GetDebtItemsWithDebtId(id);

            return debtItems;
        }
    }
}
