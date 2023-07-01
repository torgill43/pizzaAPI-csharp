using AutoMapper;
using pizzaAPI_csharp.Dto;
using pizzaAPI_csharp.Models;

namespace pizzaAPI_csharp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();
        }
    }
}
