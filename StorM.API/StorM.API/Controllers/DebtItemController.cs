using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Services.Interfaces;

namespace StorM.API.Controllers
{
    [Route("api/items")]
    [ApiController]
    public class DebtItemController : ControllerBase
    {
        private readonly IDebtItemService _debtItemService;

        public DebtItemController(IDebtItemService debtItemService)
        {
            _debtItemService = debtItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDebtItems()
        {
            var stores = await _debtItemService.GetAll();

            return Ok(stores);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetDebtItems([FromRoute] int id)
        {
            var store = await _debtItemService.GetById(id);

            if (store == null)
            {
                return NotFound();
            }

            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] DebtItem debtItem)
        {
            await _debtItemService.Add(debtItem);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] DebtItem debtItem)
        {
            await _debtItemService.Update(id, debtItem);

            return Ok();
        }

        [HttpGet]
        [Route("debt/{id}")]
        public async Task<IActionResult> GetDebtItemsByDebtId([FromRoute] int id)
        {
            var debtItems = await _debtItemService.GetDebtItemsWithDebtId(id);

            return Ok(debtItems);
        }
    }
}
