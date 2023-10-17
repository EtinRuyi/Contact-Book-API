using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IContactService
    {
        Task<List<ContactDto>> GetAllContactAsync(PaginationFilterDto filter);
        Task<Contact> GetContactByIdAsync(int Id);
        Task<Contact> GetByEmailAsync(string email);
        Task<bool> AddContactAsync(ContactDto contact);
        Task<bool> UpdateContactAsync(int Id, ContactDto contact);
        Task UpdatePhotoAsyn(int Id, string photoUrl);
        Task DeleteContactAsyn(Contact contact);
        IQueryable<Contact> SearchContactAsync(string name, string state, string city);
    }
}
