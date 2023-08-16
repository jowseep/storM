using Microsoft.EntityFrameworkCore;
using StorM.API.Models;
using StorM.API.Repositories.Data;
using StorM.API.Repositories.Interfaces;

namespace StorM.API.Repositories
{
    public class StoreRepository : BaseStoreRepository<Store>
    {
        public StoreRepository(StoreInfoContext storeInfoContext) : base(storeInfoContext)
        {
        }

    }
}
