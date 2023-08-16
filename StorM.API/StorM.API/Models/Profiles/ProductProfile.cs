using AutoMapper;

namespace StorM.API.Models.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductWithoutDebtItemsAndStore>();
        }
    }
}
