using MarketApp_DAL.Data;
using MarketApp_DAL.Repository;
using MarketApp_DomainModels;

namespace MarketApp_DAL.Implementation
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public RecipeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(Recipe entity)
        {
            _dbContext.Recipe.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Recipe entity)
        {
            _dbContext.Recipe.Remove(entity);
            _dbContext.SaveChanges();
        }

        public async Task<IEnumerable<Recipe>> GetAll()
        {
            return _dbContext.Recipe;
        }

        public async Task<Recipe> GetById(int id)
        {
            return _dbContext.Recipe
                .SingleOrDefault(x => x.Id == id);
        }

        public async Task<IQueryable<Recipe>> GetFilteredRecipes(string name)
        {
            return _dbContext.Recipe.Where(x => x.Name.ToLower().Contains(name.ToLower())
            || x.Type.ToLower().Contains(name.ToLower()) || x.Ingredients.ToLower().Contains(name.ToLower()));
        }

        public async void Update(Recipe entity)
        {
            Recipe recipe = await GetById(entity.Id);
            _dbContext.Entry(recipe).CurrentValues.SetValues(entity);
            _dbContext.SaveChanges();
            //_dbContext.Update(entity);

        }
    }
}
