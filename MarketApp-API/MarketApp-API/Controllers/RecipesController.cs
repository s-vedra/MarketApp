using MarketApp_DTO;
using MarketApp_Services.Abstraction;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MarketApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeService _recipeService;
        public RecipesController(IRecipeService recipeService)
        {
            _recipeService = recipeService;
        }
        //api/Recipes/recipes
        [HttpGet("recipes")]
        public IActionResult GetRecipes()
        {

            List<RecipeDTO> recipes = _recipeService.GetRecipes();
            return Ok(recipes);
        }

        //api/Recipes/recipe/id
        [HttpGet("recipe/{id}")]
        public IActionResult GetRecipe([FromRoute] int id)
        {
            //;
            return Ok(_recipeService.GetRecipe(id));
        }

        //api/Recipes/recipe/name
        [HttpGet("recipes/{name}")]
        public IActionResult FilterRecipes([FromRoute] string name)
        {
            return Ok(_recipeService.FilterRecipes(name));
        }

        //api/Recipes/recipe
        [HttpPost("recipe")]
        public IActionResult AddRecipe([FromBody] RecipeDTO model)
        {
            _recipeService.AddRecipe(model);
            return Ok();
        }

        //api/Recipes/recipe/id/edit
        [HttpPatch("recipe/{id}/edit")]
        public IActionResult UpdateRecipe([FromBody] RecipeDTO model)
        {
            _recipeService.UpdateRecipe(model);
            return Ok();
        }
        //api/Recipes/delete/id
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteRecipe([FromRoute] int id)
        {
            _recipeService.DeleteRecipe(id);
            return Ok();
        }

        //api/Recipes/recipe/{id}/favorite
        [HttpPost("recipe/{id}/favorite")]
        public async Task<IActionResult> AddToFavorites([FromBody] UserFavoriteRecipeDTO model)
        {
            try
            {
                await _recipeService.AddToFavorites(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("recipe/{id}/delete")]
        [AllowAnonymous]
        public IActionResult RemoveFavoriteRecipe([FromRoute] int id)
        {
            _recipeService.RemoveFavoriteRecipe(id);
            return Ok();
        }
    }
}
