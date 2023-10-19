using ContactBookAPI.Model.DTOs.ContactDto;
using ContactBookAPI.Model.Entities;
using ContactBookAPI.Model.Entities.Shared;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IContactService
    {        
        Task<BaseResponse<Contact>> AddContactAsync(ContactToAddDto model);
        Task<BaseResponse<Contact>> GetContactByIdAsync(string contactId);
        Task<BaseResponse<Contact>> GetContactByEmailAsync(string email);
        Task<BaseResponse<IEnumerable<Contact>>> GetAllContactAsync(int page, int pageSize);
        Task<BaseResponse<IEnumerable<Contact>>> SearchContactAsync(string searchTerm);
        Task<BaseResponse<Contact>> UpdateContactAsync(string contactId, ContactToUpdateDto model);
        Task <BaseResponse<Contact>>DeleteContactAsyn(string contactId);
    }
}
