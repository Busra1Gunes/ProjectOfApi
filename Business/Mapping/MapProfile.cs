using AutoMapper;
using Core;
using Entities;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {

            CreateMap<Product, ProductDto>()
                //.ForMember(dest => dest., opt => opt.MapFrom(x => x.Rol.ad))
                .ReverseMap();
        }
    }
}
