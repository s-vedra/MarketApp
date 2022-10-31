using AutoMapper;
using MarketApp_DAL.Implementation;
using MarketApp_DAL.Repository;
using MarketApp_Services.Abstraction;
using MarketApp_Services.Implementation;
using MarketApp_Services.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace MarketAPI_Utilities
{
    public static class DependencyInjectionUtility
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection service)
        {

            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IRecipeRepository, RecipeRepository>();
            service.AddScoped<IRecipeService, RecipeService>();

            //automapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            service.AddSingleton(mapper);
            return service;
            return service;
        }
    }
}