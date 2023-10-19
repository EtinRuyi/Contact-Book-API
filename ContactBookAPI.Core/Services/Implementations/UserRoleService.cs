using ContactBookAPI.Commons.Helpers.UtilityHelpers;
using ContactBookAPI.Core.Services.Interface;
using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;
using ContactBookAPI.Model.Entities.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ContactBookAPI.Core.Services.Implementations
{
    public class UserRoleService : IUserRoleService
    {
        private readonly RoleManager<UserRole> _roleManager;
        private readonly UserRoleRepository _userRoleRepository;
        public UserRoleService(RoleManager<UserRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto addUserRoleDto)
        {
            try
            {
                var existingUserRole = await _roleManager.FindByNameAsync(addUserRoleDto.Name);

                if (existingUserRole == null)
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("Role already exists",
                                                                        StatusCodes.Status400BadRequest,
                                                                        new UserRoleToReturnDto { Name = existingUserRole.Name },
                                                                        null, false);

                var roleToAdd = new UserRole { Name = addUserRoleDto.Name, NormalizedName = addUserRoleDto.Name.ToUpper() };
                var response = await _roleManager.CreateAsync(roleToAdd);

                if (response.Succeeded)
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("Role successfully created", StatusCodes.Status200OK,
                                                                        new UserRoleToReturnDto { Name = roleToAdd.Name, Id = roleToAdd.Id },
                                                                        null, true);

                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("something went wrong", StatusCodes.Status400BadRequest,
                                                                    null, null, true);
            }
            catch (Exception)
            {

                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("An error occurred", StatusCodes.Status500InternalServerError, null, null, false);
            }

        }

        public Task<BaseResponse<UserRoleToReturnDto>> DeleteUserRoleAsync(DeleteUserRoleDto deleteUserRoleDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto updateUserRoleDto)
        {
            try
            {
                var existingUserRole = await _roleManager.FindByNameAsync(updateUserRoleDto.NewRole.ToString());

                if (existingUserRole == null)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("Role does not exist",
                                                            StatusCodes.Status400BadRequest,
                                                            null, null, false);
                }

                var userRole = await _roleManager.FindByIdAsync(updateUserRoleDto.UserId);
                if (userRole == null)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("User role not found",
                                                            StatusCodes.Status400BadRequest,
                                                            null, null, false);
                }

                // Update the user's role
                userRole.Name = updateUserRoleDto.NewRole.ToString();
                var result = await _roleManager.UpdateAsync(userRole);

                if (result.Succeeded)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("User role updated successfully", StatusCodes.Status200OK,
                                                            new UserRoleToReturnDto { Name = userRole.Name, Id = userRole.Id },
                                                            null, true);
                }

                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("Failed to update user role", StatusCodes.Status400BadRequest, null, null, false);
            }
            catch (Exception)
            {
                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("An error occurred", StatusCodes.Status500InternalServerError, null, null, false);
            }
        }


    }
}
