using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IUserRoleRepository
    {
        Task<UserRole> AddUserRoleAsync(UserRole userRole);
        Task<UserRole> UpdateUserRoleAsync(UserRole userRole);
        Task DeleteUserRoleAsync(string roleId);
    }
}
