using MarketApp_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp_Services.Abstraction
{
    public interface IUserService
    {
        Task<List<FavoriteRecipeDTO>> GetFavoriteRecipes(string userId);
    }
}
