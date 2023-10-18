using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IUserService
    {
        Task<bool> CreateNewUserAsync(UserToAddDto model, ModelStateDictionary modelState);
        Task<bool> UpdateUserAsync(string userId, UpdateUserDto model);
        Task<PaginationDto> GetAllUserAsync(int page, int pagesize);
        Task<bool> DeleteUserAsync(string userId);
        Task<User> GetUserByidAsync(string userId);
        Task<User> GetUserByEmailAsync(string email);




        Task<User> CreateUserAsync(User user);
        Task<User> GetUserByIdAsync(string userId);
        Task<User> GetUserByEmailAsync(string email);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<IEnumerable<User>> SearchUsersAsync(string searchTerm);
        Task<User> UpdateUserAsync(string userId, User updatedUser);
        Task DeleteUserAsync(string userId);
    }
}