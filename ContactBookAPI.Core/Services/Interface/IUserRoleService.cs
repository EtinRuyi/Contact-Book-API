using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities.Shared;
using ContactBookAPI.Model.Enums;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IUserRoleService
    {
        Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto addUserRoleDto);
        Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto updateUserRoleDto);
    }
}
