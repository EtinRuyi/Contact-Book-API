using ContactBookAPI.Data.Repositories.Interface;
using ContactBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBookAPI.Data.Repositories.Implementations
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ContactBookAPIDbContext _dbContext;
        public UserRoleRepository(ContactBookAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task<bool> SaveChangesAsync() => await _dbContext.SaveChangesAsync() > 0;
        public async Task<bool> AddUserRoleAsync(UserRole userRole)
        {
            await _dbContext.UserRoles.AddAsync(userRole);
            return await SaveChangesAsync();
        }
        public async Task<bool> UpdateUserRoleAsync(UserRole userRole)
        {
            _dbContext.UserRoles.Update(userRole);
            return await SaveChangesAsync();
        }
        public async Task<bool> DeleteUserRoleAsync(string roleId)
        {
            var userRole = await _dbContext.UserRoles.FirstOrDefaultAsync(ur => ur.Id == roleId);

            if (userRole != null)
            {
                _dbContext.UserRoles.Remove(userRole);
                return await SaveChangesAsync();
            }

            return false;
        }
    }
}