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
        public async Task<User> CreateUserAsync(User user)
        {
            var result = await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            return result.Entity;
        }

        public async Task DeleteUserAsync(string userId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User> GetUserByIdAsync(string userId)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<IEnumerable<User>> SearchUsersAsync(string searchTerm)
        {
            return await _dbContext.Users.Where(u => u.FirstName.Contains(searchTerm) || u.LastName.Contains(searchTerm)).ToListAsync();
        }

        public async Task<User> UpdateUserAsync(string userId, User updatedUser)
        {
            var existingUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);

            if (existingUser != null)
            {
                existingUser.FirstName = updatedUser.FirstName;
                existingUser.LastName = updatedUser.LastName;
                existingUser.Email = updatedUser.Email;
                existingUser.PhoneNumber = updatedUser.PhoneNumber;

                await _dbContext.SaveChangesAsync();
            }

            return existingUser;
        }
    }
}
