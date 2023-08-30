using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class DebtService : GenericService<DebtWithoutDebtItems, Debt>, IDebtService
    {
        private readonly IDebtRepository _debtRepository;
        private readonly IMapper _mapper;
        public DebtService(IDebtRepository repository, IMapper imapper) : base(repository, imapper)
        {
            _debtRepository = repository;
            _mapper = imapper;
        }

        public async Task<int> AddDebtWithDebtItems(int id, decimal total, DateTime date, List<DebtItemsWithoutProductAndDebt> debtItems)
        {
            var affectedRows = await _debtRepository.AddDebtWithDebtItems(id, total, date, debtItems);
            return affectedRows;
        }

        public async Task<IEnumerable<DebtWithoutDebtItems>> GetDebtByBorrowerId(int id)
        {
            var debts = await _debtRepository.GetDebtByBorrowerId(id);
            return _mapper.Map<IEnumerable<DebtWithoutDebtItems>>(debts);
        }
    }
}
