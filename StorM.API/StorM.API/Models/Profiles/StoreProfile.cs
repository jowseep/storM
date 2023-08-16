using AutoMapper;

namespace StorM.API.Models.Profiles
{
    public class StoreProfile : Profile
    {
        public StoreProfile()
        {
            CreateMap<Store, StoreClientDetails>();
        }
    }
}
