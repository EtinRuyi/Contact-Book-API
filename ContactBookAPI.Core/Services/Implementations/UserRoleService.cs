using ContactBookAPI.Commons.Helpers.UtilityHelpers;
using ContactBookAPI.Core.Services.Interface;
using ContactBookAPI.Data.Repositories.Interface;
using ContactBookAPI.Model.DTOs.UserRoleDto;
using ContactBookAPI.Model.Entities;
using ContactBookAPI.Model.Entities.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace ContactBookAPI.Core.Services.Implementations
{
    public class UserRoleService : IUserRoleService
    {
        private readonly RoleManager<UserRole> _roleManager;
        private readonly IUserRoleRepository _userRoleRepository;
        public UserRoleService(RoleManager<UserRole> roleManager, IUserRoleRepository userRoleRepository)
        {
            _roleManager = roleManager;
            _userRoleRepository = userRoleRepository;
        }
        public async Task<BaseResponse<UserRoleToReturnDto>> AddUserRoleAsync(AddUserRoleDto model)
        {
            try
            {
                var existingUserRole = await _roleManager.FindByNameAsync(model.Name);

                if (existingUserRole != null)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("Role already exists",
                                                            StatusCodes.Status400BadRequest,
                                                            new UserRoleToReturnDto { Name = existingUserRole.Name },
                                                            null, false);
                }

                var roleToAdd = new UserRole { Name = model.Name, NormalizedName = model.Name.ToUpper() };
                var response = await _roleManager.CreateAsync(roleToAdd);

                if (response.Succeeded)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("Role successfully created", StatusCodes.Status200OK,
                                                            new UserRoleToReturnDto { Name = roleToAdd.Name, Id = roleToAdd.Id },
                                                            null, true);
                }

                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("Something went wrong", StatusCodes.Status400BadRequest, null, null, false);
            }
            catch (Exception)
            {
                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("An error occurred", StatusCodes.Status500InternalServerError, null, null, false);
            }
        }

        public async Task<BaseResponse<UserRoleToReturnDto>> DeleteUserRoleAsync(string roleId)
        {
            try
            {
                var userRole = await _roleManager.FindByIdAsync(roleId);

                if (userRole == null)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("User role not found",
                                                            StatusCodes.Status400BadRequest,
                                                            null, null, false);
                }

                var result = await _roleManager.DeleteAsync(userRole);

                if (result.Succeeded)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("User role deleted successfully", StatusCodes.Status200OK, null, null, true);
                }

                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("Failed to delete user role", StatusCodes.Status400BadRequest, null, null, false);
            }
            catch (Exception)
            {
                return UtilityHelper
                    .BuildResponse<UserRoleToReturnDto>("An error occurred", StatusCodes.Status500InternalServerError, null, null, false);
            }
        }


        public async Task<BaseResponse<UserRoleToReturnDto>> UpdateUserRoleAsync(UpdateUserRoleDto model)
        {
            try
            {
                var existingUserRole = await _roleManager.FindByNameAsync(model.NewRoleName.ToString());

                if (existingUserRole == null)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("Role does not exist",
                                                        StatusCodes.Status400BadRequest,
                                                        null, null, false);
                }

                // Fetch the user role by ID (assuming you have a UserRoleId in the DTO)
                var userRole = await _roleManager.FindByIdAsync(model.UserRoleId);

                if (userRole == null)
                {
                    return UtilityHelper
                        .BuildResponse<UserRoleToReturnDto>("User role not found",
                                                        StatusCodes.Status400BadRequest,
                                                        null, null, false);
                }

                // Update the user's role
                userRole.Name = model.NewRoleName.ToString();
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
