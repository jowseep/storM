using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Services;
using StorM.API.Services.Interfaces;

namespace StorM.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaidTransactionController: ControllerBase
    {
        private readonly IPaidTransactionService _paidTransactionService;

        public PaidTransactionController(IPaidTransactionService paidTransactionService)
        {
            _paidTransactionService = paidTransactionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaidTransactions()
        {
            var paidTransactions = await _paidTransactionService.GetAll();

            return Ok(paidTransactions);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetPaidTransactionById([FromRoute] int id)
        {
            var paidTransaction = await _paidTransactionService.GetById(id);

            if (paidTransaction == null)
            {
                return NotFound();
            }

            return Ok(paidTransaction);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PaidTransaction paidTransaction)
        {
            await _paidTransactionService.Add(paidTransaction);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] PaidTransaction paidTransaction)
        {
            await _paidTransactionService.Update(id, paidTransaction);

            return Ok();
        }
    }
}
