using AutoMapper;
using MarketApp_DAL.Repository;
using MarketApp_DomainModels;
using MarketApp_DTO;
using MarketApp_Services.Abstraction;
using System.Linq;

namespace MarketApp_Services.Implementation
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public RecipeService(IRecipeRepository recipeRepository, IMapper mapper, IUserRepository userRepository)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public void AddRecipe(RecipeDTO model)
        {
           var recipe = _mapper.Map<Recipe>(model);
            _recipeRepository.Add(recipe);
        }

        public async Task AddToFavorites(UserFavoriteRecipeDTO model)
        {
           
            FavoriteRecipe favoriteRecipe = new FavoriteRecipe()
            {
                ApplicationUserId = model.UserId,
                RecipeId = model.RecipeId,
                Recipe = await _recipeRepository.GetById(model.RecipeId),
                ApplicationUser = await _userRepository.GetById(model.UserId)
            };

            if (_userRepository.GetFavoriteRecipes(favoriteRecipe.ApplicationUserId).Result.Any(x => x.RecipeId == favoriteRecipe.RecipeId))
            {
                throw new Exception("Already exists");
            }
            _recipeRepository.AddFavoriteRecipe(favoriteRecipe);
        }

        public async void DeleteRecipe(int id)
        {
           Recipe recipe = await _recipeRepository.GetById(id);
            _recipeRepository.Delete(recipe);
        }

        public List<RecipeDTO> FilterRecipes(string name)
        {
          return _recipeRepository.GetFilteredRecipes(name).Result.Select(x => _mapper.Map<RecipeDTO>(x)).ToList();
        }

        public RecipeDTO GetRecipe(int id)
        {
            return _mapper.Map<RecipeDTO>(_recipeRepository.GetById(id).Result);
        }

        public List<RecipeDTO> GetRecipes()
        {
            return _recipeRepository.GetAll().Result.Select(x => _mapper.Map<RecipeDTO>(x)).ToList();
        }

        public async void RemoveFavoriteRecipe(int recipeId)
        {
            var recipe = await _recipeRepository.GetFavoriteRecipe(recipeId);
            _recipeRepository.RemoveFavoriteRecipe(recipe);
        }

        public void UpdateRecipe(RecipeDTO model)
        {
            _recipeRepository.Update(_mapper.Map<Recipe>(model));
        }
    }
}
