using AutoMapper;
using MarketApp_DomainModels;
using MarketApp_DTO;

namespace MarketApp_Services.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<RecipeDTO, Recipe>().ReverseMap();
            CreateMap<AddRecipeDTO, Recipe>().ReverseMap();
            CreateMap<RegisterDTO, ApplicationUser>().ReverseMap();
            CreateMap<UserDTO, ApplicationUser>().ReverseMap();
            CreateMap<FavoriteRecipeDTO, FavoriteRecipe>().ReverseMap();

        }
    }
}
