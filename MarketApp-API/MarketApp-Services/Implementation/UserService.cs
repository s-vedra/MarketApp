using AutoMapper;
using MarketApp_DAL.Repository;
using MarketApp_DTO;
using MarketApp_Services.Abstraction;

namespace MarketApp_Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<List<FavoriteRecipeDTO>> GetFavoriteRecipes(string userId)
        {
            List<FavoriteRecipeDTO> favoriteRecipes = _userRepository.GetFavoriteRecipes(userId).Result.
                Select(x => _mapper.Map<FavoriteRecipeDTO>(x)).ToList();
            if (favoriteRecipes.Count == 0)
            {
                throw new Exception("No recipes added yet");
            }
            return favoriteRecipes;
        }
    }
}
