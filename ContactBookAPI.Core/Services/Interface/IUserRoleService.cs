using ContactBookAPI.Model.DTOs.UserRoleDto;
using ContactBookAPI.Model.Entities;
using ContactBookAPI.Model.Entities.Shared;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IUserRoleService
    {
        Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto model);
        Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto model);
        Task<BaseResponse<UserRoleToReturnDto>> DeleteUserRoleAsync(string roleId);
    }
}