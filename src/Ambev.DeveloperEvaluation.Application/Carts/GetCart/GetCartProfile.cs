using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Carts.GetCart
{
    public class GetCartProfile : Profile
    {
        public GetCartProfile()
        {
            CreateMap<Cart, GetCartResult>()
                .ForMember(dest => dest.TotalSalePrice, opt => opt.MapFrom(src => src.TotalSalePrice.Value));
        }
    }
}
