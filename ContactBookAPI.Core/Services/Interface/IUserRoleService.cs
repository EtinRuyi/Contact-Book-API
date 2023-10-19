using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities.Shared;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IUserRoleService
    {
        Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto addUserRoleDto);
        Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto updateUserRoleDto);
        Task<BaseResponse<UserRoleToReturnDto>> DeleteUserRoleAsync(DeleteUserRoleDto deleteUserRoleDto);
    }
}