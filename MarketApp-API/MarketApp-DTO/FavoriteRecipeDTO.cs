namespace MarketApp_DTO
{
    public class FavoriteRecipeDTO
    {
        public int RecipeId { get; set; }
        public RecipeDTO Recipe { get; set; }
        public string UserId { get; set; }
        public UserDTO User { get; set; }
    }
}
