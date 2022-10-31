using MarketApp_DAL.Repository;
using MarketApp_DomainModels;
using MarketApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_Services.Abstraction
{
    public interface IRecipeService
    {
        List<RecipeDTO> GetRecipes();
        RecipeDTO GetRecipe(int id);
        List<RecipeDTO> FilterRecipes(string name);
        void AddRecipe(RecipeDTO model);
        void UpdateRecipe(RecipeDTO model);
        void DeleteRecipe(int id);
        void AddToFavorites(int id);

    }
}
