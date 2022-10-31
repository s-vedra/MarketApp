using MarketApp_DAL.Data;
using MarketApp_DAL.Repository;
using MarketApp_DomainModels;
using Microsoft.EntityFrameworkCore;

namespace MarketApp_DAL.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ApplicationUser> GetById(string id)
        {
            return _dbContext.Users.SingleOrDefault(x => x.Id == id);
        }

        public async Task<IQueryable<FavoriteRecipe>> GetFavoriteRecipes(string userId)
        {
           return _dbContext.FavoriteRecipes.Include(x => x.Recipe).Where(x => x.ApplicationUserId == userId);
        }
    }
}
