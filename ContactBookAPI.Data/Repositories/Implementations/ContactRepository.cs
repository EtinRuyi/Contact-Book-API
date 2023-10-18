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
        public async Task<bool> AddContactAsync(Contact contact, string userId)
        {
            await _dbContext.Contacts.AddAsync(contact);
            return await _dbContext.SaveChangesAsync() > 1;
        }

        public async Task DeleteContactAsyn(Contact contact)
        {
            _dbContext.Contacts.Remove(contact);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Contact> GetContactByEmailAsync(string email)
        {
            return await _dbContext.Contacts.FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task<Contact> GetContactByIdAsync(int Id)
        {
            return await _dbContext.Contacts.FindAsync(Id);
        }

        public async Task<List<Contact>> GetAllContactAsync()
        {
            return await _dbContext.Contacts.ToListAsync();
        }

        public IQueryable<Contact> SearchContactAsync(string name, string address)
        {
            var query = _dbContext.Contacts.AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(contact => contact.FirstName.Contains(name) || contact.LastName.Contains(name));
            }

            if (!string.IsNullOrEmpty(address))
            {
                query = query.Where(contact => contact.Address.City.Contains(address));
            }
            return query;
        }

        public async Task UpdatePhotoAsync(int Id, string photoUrl)
        {
            var existingContact = await _dbContext.Contacts.FindAsync(Id);

            if (existingContact != null)
            {
                existingContact.PhotoUrl = photoUrl;
                _dbContext.Contacts.Update(existingContact);
                await _dbContext.SaveChangesAsync();
            }
        }

        //public async Task<bool> UpdateContactAsync(int Id, Contact contact)
        //{
        //    var existingContact = await _dbContext.Contacts.FindAsync(Id);

        //    if (existingContact != null)
        //    {
        //        existingContact.FirstName = contact.FirstName;
        //        existingContact.LastName = contact.LastName;
        //        existingContact.Email = contact.Email;

        //        _dbContext.Contacts.Update(existingContact);
        //        return await _dbContext.SaveChangesAsync() > 0;
        //    }
        //    return false;
        //}
    }
}
