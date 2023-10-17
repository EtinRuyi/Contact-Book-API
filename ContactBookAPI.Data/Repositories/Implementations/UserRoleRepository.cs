using ContactBookAPI.Data.Repositories.Interface;
using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities.Shared;

namespace ContactBookAPI.Data.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        public Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto addUserRoleDto)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto updateUserRoleDto)
        {
            throw new NotImplementedException();
        }
    }
}
