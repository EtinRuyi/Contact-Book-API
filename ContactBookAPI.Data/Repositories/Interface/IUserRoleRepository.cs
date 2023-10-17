using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities.Shared;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IUserRoleRepository
    {
        Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto addUserRoleDto);
        Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto updateUserRoleDto);
    }
}
