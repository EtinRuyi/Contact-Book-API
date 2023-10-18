using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByIdAsync(string userId);
        Task<User> GetUserByEmailAsync(string email);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<IEnumerable<User>> SearchUsersAsync(string searchTerm);
        Task<User> UpdateUserAsync(string userId, User updatedUser);
        Task DeleteUserAsync(string userId);
    }
}
