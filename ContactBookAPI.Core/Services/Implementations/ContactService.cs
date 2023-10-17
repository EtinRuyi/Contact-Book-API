using ContactBookAPI.Core.Services.Interface;
using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Core.Services.Implementations
{
    public class ContactService : IContactService
    {
        public Task<bool> AddContactAsync(ContactDto contact)
        {
            throw new NotImplementedException();
        }

        public Task DeleteContactAsyn(Contact contact)
        {
            throw new NotImplementedException();
        }

        public Task<List<ContactDto>> GetAllContactAsync(PaginationFilterDto filter)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<Contact> GetContactByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Contact> SearchContactAsync(string name, string state, string city)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateContactAsync(int Id, ContactDto contact)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePhotoAsyn(int Id, string photoUrl)
        {
            throw new NotImplementedException();
        }
    }
}
