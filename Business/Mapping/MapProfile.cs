using AutoMapper;
using Core;
using Entities;
using Entities.Concrete;
using Entities.Dto;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;

namespace Service.Mapping
{
    public class MapProfile : Profile
    {

        public MapProfile(IHttpContextAccessor httpContextAccessor)
        {
            CreateMap<Comment, CommentAddDto>().ReverseMap();
            CreateMap<Product, ProductDto>()
                //.ForMember(dest => dest., opt => opt.MapFrom(x => x.Rol.ad))
                .ReverseMap();
			CreateMap<Category, CategoryDto>()
			  .ReverseMap();
            CreateMap<Category, CreateCategoryDto>()
				.ReverseMap(); 
            CreateMap<Category, UpdateCategoryDto>()
				.ReverseMap();

            CreateMap<Email, EmailDto>().ReverseMap();
            CreateMap<Email, EmailRequest>().ReverseMap();
            CreateMap<Email, SendEmailDto>().ReverseMap();

        }
    }
}
