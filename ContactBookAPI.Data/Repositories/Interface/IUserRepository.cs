using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IUserRepository
    {
        Task<bool> CreateNewUserAsync(UserToAddDto model, ModelStateDictionary modelState);
        Task<bool> UpdateUserAsync(string userId, UpdateUserDto model);
        Task<PaginationDto> GetAllUserAsync(int page, int pagesize);
        Task<bool> DeleteUserAsync(string userId);
        Task<User> GetUserByidAsync(string userId);
        Task<User> GetUserByEmailAsync(string email);
    }
}
