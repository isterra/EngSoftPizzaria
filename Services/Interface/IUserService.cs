using Models.DataBaseModels;

namespace Services.Interface
{
    public interface IUserService
    {
        Task<User> CreateUserAsync(User createUserModel);
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByEmailAsync(string email);
    }
}
