using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<bool> CreateUserAsync(User user);
        Task<User> GetUserByIdAsync(string userId);
        Task<User> GetUserByEmailAsync(string email);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<IEnumerable<User>> SearchUsersAsync(string searchTerm);
        Task<bool> UpdateUserAsync(string userId, User updatedUser);
        Task<bool> DeleteUserAsync(string userId);
    }
}
