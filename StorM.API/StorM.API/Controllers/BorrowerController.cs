using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Services.Interfaces;

namespace StorM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowerController : ControllerBase
    {
        private readonly IBorrowerService _borrowerService;
        public BorrowerController(IBorrowerService borrowerService)
        {
            _borrowerService = borrowerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var borrowers = await _borrowerService.GetAll();

            return Ok(borrowers);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBorrowerById([FromRoute] int id)
        {
            var borrower = await _borrowerService.GetById(id);

            if (borrower == null)
            {
                return NotFound();
            }

            return Ok(borrower);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Borrower borrower)
        {
            await _borrowerService.Add(borrower);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Borrower borrower)
        {
            await _borrowerService.Update(id, borrower);

            return Ok();
        }
    }
}
