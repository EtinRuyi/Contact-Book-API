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
        public async Task<UserRole> AddUserRoleAsync(UserRole userRole)
        {
            var result = await _dbContext.UserRoles.AddAsync(userRole);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<UserRole> UpdateUserRoleAsync(UserRole userRole)
        {
            _dbContext.UserRoles.Update(userRole);
            await _dbContext.SaveChangesAsync();
            return userRole;
        }

        public async Task DeleteUserRoleAsync(string roleId)
        {
            var userRole = await _dbContext.UserRoles.FirstOrDefaultAsync(ur => ur.Id == roleId);

            if (userRole != null)
            {
                _dbContext.UserRoles.Remove(userRole);
                await _dbContext.SaveChangesAsync();
            }
        }
}
