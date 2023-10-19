using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IUserRoleRepository
    {
        Task<bool> AddUserRoleAsync(UserRole userRole);
        Task<bool> UpdateUserRoleAsync(UserRole userRole);
        Task<bool> DeleteUserRoleAsync(string roleId);
    }
}
