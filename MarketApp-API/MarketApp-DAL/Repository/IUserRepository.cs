using MarketApp_DomainModels;

namespace MarketApp_DAL.Repository
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetById(string id);
        Task<IQueryable<FavoriteRecipe>> GetFavoriteRecipes(string userId);
    }
}
