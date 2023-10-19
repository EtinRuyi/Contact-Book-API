using ContactBookAPI.Data.Repositories.Interface;
using ContactBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBookAPI.Data.Repositories.Implementations
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactBookAPIDbContext _dbContext;
        public ContactRepository(ContactBookAPIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private async Task<bool> SaveChangesAsync() => await _dbContext.SaveChangesAsync() > 0;

        public async Task<bool> AddContactAsync(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteContactAsyn(Contact contact)
        {
            _dbContext.Contacts.Remove(contact);
            return await SaveChangesAsync();
        }

        public async Task<Contact> GetContactByEmailAsync(string email) => await _dbContext.Contacts.FirstOrDefaultAsync(c => c.Email == email);

        public async Task<Contact> GetUserByIdAsync(int id) => await _dbContext.Contacts.FindAsync(id);

        public async Task<IEnumerable<Contact>> GetAllContactAsync() => await _dbContext.Contacts.ToListAsync();

        public async Task<IEnumerable<Contact>> SearchContactAsync(string searchTerm) => await _dbContext.Contacts.Where(c => c.FirstName.Contains(searchTerm) || c.Email.Contains(searchTerm)).ToListAsync();

        public async Task<bool> UpdateContactAsync(int id, Contact contact)
        {
            var existingContact = await _dbContext.Contacts.FindAsync(id);

            if (existingContact != null)
            {
                _dbContext.Entry(existingContact).CurrentValues.SetValues(contact);
                return await SaveChangesAsync();
            }

            return false;
        }
    }
}
