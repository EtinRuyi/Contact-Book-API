using ContactBookAPI.Model.DTOs;
using ContactBookAPI.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBookAPI.Data.Repositories.Interface
{
    public interface IContactRepository
    {
        Task<bool> AddContactAsync(Contact contact, string userId);
        Task<Contact> GetContactByEmailAsync(string email);
        Task<Contact> GetContactByIdAsync(int Id);
        Task<List<Contact>> GetAllContactAsync();
        IQueryable<Contact> SearchContactAsync(string name, string address);
        Task<bool> UpdateContactAsync(int Id, Contact contact);
        Task UpdatePhotoAsync(int Id, string photoUrl);
        Task DeleteContactAsyn(Contact contact);
    }
}
