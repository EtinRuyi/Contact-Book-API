using ContactBookAPI.Core.Services.Interface;
using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ContactBookAPI.Core.Services.Implementations
{
    public class UserService : IUserService
    {
        public Task<bool> CreateNewUserAsync(UserToAddDto model, ModelStateDictionary modelState)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationDto> GetAllUserAsync(int page, int pagesize)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByidAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateUserAsync(string userId, UpdateUserDto model)
        {
            throw new NotImplementedException();
        }
    }
}
