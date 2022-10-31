using AutoMapper;
using MarketApp_DAL.Repository;
using MarketApp_DomainModels;
using MarketApp_DTO;
using MarketApp_Services.Abstraction;

namespace MarketApp_Services.Implementation
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IMapper _mapper;
        public RecipeService(IRecipeRepository recipeRepository, IMapper mapper)
        {
            _recipeRepository = recipeRepository;
            _mapper = mapper;
        }

        public void AddRecipe(RecipeDTO model)
        {
           var recipe = _mapper.Map<Recipe>(model);
            _recipeRepository.Add(recipe);
        }

        public void AddToFavorites(int id)
        {
            throw new NotImplementedException();
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

        public void UpdateRecipe(RecipeDTO model)
        {
            _recipeRepository.Update(_mapper.Map<Recipe>(model));
        }
    }
}
