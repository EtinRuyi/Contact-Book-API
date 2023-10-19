using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IContactRepository
    {
        Task<bool> AddContactAsync(Contact contact);
        Task<Contact> GetContactByEmailAsync(string email);
        Task<Contact> GetUserByIdAsync(int id);
        Task<IEnumerable<Contact>> GetAllContactAsync();
        Task<IEnumerable<Contact>> SearchContactAsync(string searchTerm);
        Task<bool> DeleteContactAsyn(Contact contact);
        Task<bool> UpdateContactAsync(int Id, Contact contact);
    }
}
