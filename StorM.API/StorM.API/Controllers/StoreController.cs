using Microsoft.AspNetCore.Mvc;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Services;

namespace StorM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly StoreService _storeService;

        public StoreController(StoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStore()
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


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Store store)
        {
            await _storeService.Add(store);

            return Ok();
        }
    }
}
