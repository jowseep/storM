using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Services.Interfaces;

namespace StorM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DebtController : ControllerBase
    {
        private readonly IDebtService _debtService;
        public DebtController(IDebtService debtService)
        {
            _debtService = debtService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDebts()
        {
            var borrowers = await _debtService.GetAll();

            return Ok(borrowers);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDebtById([FromRoute] int id)
        {
            var borrower = await _debtService.GetById(id);

            if (borrower == null)
            {
                return NotFound();
            }

            return Ok(borrower);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Debt debt)
        {
            await _debtService.Add(debt);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Debt debt)
        {
            await _debtService.Update(id, debt);

            return Ok();
        }

        [HttpGet]
        [Route("borrower/{id}")]
        public async Task<IActionResult> GetDebtsByBorrowerId([FromRoute] int id)
        {
            var debts = await _debtService.GetDebtByBorrowerId(id);

            return Ok(debts);
        }

        [HttpPost]
        [Route("borrower/{id}/add")]
        public async Task<IActionResult> Add([FromRoute] int id, [FromQuery] decimal total, [FromQuery] DateTime date, [FromBody] List<DebtItemsWithoutProductAndDebt> debtItems)
        {
            var affectedRows = await _debtService.AddDebtWithDebtItems(id, total, date, debtItems);

            return Ok(affectedRows);
        }
    }
}
