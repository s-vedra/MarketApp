using AutoMapper;
using MarketApp_DomainModels;
using MarketApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_Services.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<RecipeDTO, Recipe>().ReverseMap();
            CreateMap<AddRecipeDTO, Recipe>().ReverseMap();
            CreateMap<RegisterDTO, ApplicationUser>().ReverseMap();
        }
    }
}
