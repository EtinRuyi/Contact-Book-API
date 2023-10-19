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
        Task DeleteContactAsyn(Contact contact);
        IQueryable<Contact> SearchContactAsync(string name, string state, string city);


        Task<bool> AddContactAsync(Contact contact, string userId);
        Task<Contact> GetContactByEmailAsync(string email);
        Task<Contact> GetContactByIdAsync(int Id);
        Task<List<Contact>> GetAllContactAsync();
        IQueryable<Contact> SearchContactAsync(string name, string address);
        Task<bool> UpdateContactAsync(int Id, Contact contact);
        Task DeleteContactAsyn(Contact contact);
    }
}
