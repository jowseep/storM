using AutoMapper;
using StorM.API.Models;
using StorM.API.Repositories;
using StorM.API.Repositories.Interfaces;
using StorM.API.Services.Interfaces;

namespace StorM.API.Services
{
    public class ProductService : GenericService<ProductWithoutDebtItemsAndStore, Product>, IProductService
    {
        public ProductService(IProductRepository repository, IMapper imapper) : base(repository, imapper)
        {
        }
    }
}
