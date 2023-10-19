using ContactBookAPI.Data.Repositories.Interface;
using ContactBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBookAPI.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly ContactBookAPIDbContext _dbContext;
        public UserRepository(ContactBookAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task<bool> SaveChangesAsync() => await _dbContext.SaveChangesAsync() > 0;
        public async Task<bool> CreateUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteUserAsync(string userId)
        {
            var user = await _dbContext.Users.FindAsync(userId);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                return await SaveChangesAsync();
            }

            return false;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync() => await _dbContext.Users.ToListAsync();

        public async Task<User> GetUserByEmailAsync(string email) => await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

        public async Task<User> GetUserByIdAsync(string userId) => await _dbContext.Users.FindAsync(userId);

        public async Task<IEnumerable<User>> SearchUsersAsync(string searchTerm) => await _dbContext.Users.Where(u => u.FirstName.Contains(searchTerm) || u.Email.Contains(searchTerm)).ToListAsync();

        public async Task<bool> UpdateUserAsync(string userId, User updatedUser)
        {
            var existingUser = await _dbContext.Users.FindAsync(userId);

            if (existingUser != null)
            {
                _dbContext.Entry(existingUser).CurrentValues.SetValues(updatedUser);
                return await SaveChangesAsync();
            }

            return false;
        }
    }
}
