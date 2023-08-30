using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Services.Interfaces;

namespace StorM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaidDebtController : ControllerBase
    {
        private readonly IPaidDebtService _paidDebtService;

        public PaidDebtController(IPaidDebtService paidDebtService)
        {
            _paidDebtService = paidDebtService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaidDebts()
        {
            var paidDebts = await _paidDebtService.GetAll();

            return Ok(paidDebts);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPaidDebtById([FromRoute] int id)
        {
            var store = await _paidDebtService.GetById(id);

            if (store == null)
            {
                return NotFound();
            }

            return Ok(store);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PaidDebt paidDebt)
        {
            await _paidDebtService.Add(paidDebt);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PaidDebt paidDebt)
        {
            await _paidDebtService.Update(id, paidDebt);

            return Ok();
        }
    }
}
