using MarketApp_DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_DAL.Repository
{
    public interface IRecipeRepository : IRepository<Recipe, int>
    {
        Task<IQueryable<Recipe>> GetFilteredRecipes(string name);
        void AddFavoriteRecipe(FavoriteRecipe recipe);
        void RemoveFavoriteRecipe(FavoriteRecipe recipe);
        Task<FavoriteRecipe> GetFavoriteRecipe(int id);
    }
}
