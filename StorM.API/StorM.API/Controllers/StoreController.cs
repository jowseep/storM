using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Services.Interfaces;

namespace StorM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStores()
        {
            var stores = await _storeService.GetAll();

            return Ok(stores);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetStoreById([FromRoute] int id)
        {
            var store = await _storeService.GetById(id);

            if (store == null)
            {
                return NotFound();
            }

            return Ok(store);
        }

        [HttpGet]
        [Route("{id}/borrowers")]
        public async Task<IActionResult> GetBorrowersByStoreId([FromRoute] int id)
        {
            var borrowers = await _storeService.GetBorrowersByStoreId(id);

            return Ok(borrowers);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Store store)
        {
            await _storeService.Add(store);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] Store store)
        {
            await _storeService.Update(id, store);

            return Ok();
        }
    }
}
