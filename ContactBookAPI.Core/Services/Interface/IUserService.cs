using ContactBookAPI.Model.DTOs.UserDtos;
using ContactBookAPI.Model.Entities;
using ContactBookAPI.Model.Entities.Shared;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IUserService
    {
        Task<BaseResponse<User>> CreateUserAsync(UserToCreateDto model);
        Task<BaseResponse<User>> GetUserByIdAsync(string userId);
        Task<BaseResponse<User>> GetUserByEmailAsync(string email);
        Task<BaseResponse<IEnumerable<User>>> GetAllUsersAsync(int page, int pageSize);
        Task<BaseResponse<IEnumerable<User>>> SearchUsersAsync(string searchTerm);
        Task<BaseResponse<User>> UpdateUserAsync(string userId, UserToUpdateDto model);
        Task<BaseResponse<User>> DeleteUserAsync(string userId);
    }
}