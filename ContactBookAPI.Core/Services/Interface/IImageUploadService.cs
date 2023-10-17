using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace ContactBookAPI.Core.Services.Interface
{
    public interface IImageUploadService
    {
        Task<ImageUploadResult>UploadUserImageAsync(string id, IFormFile image);
        Task<DeletionResult> DeleteUserImageAsync(string id, IFormFile image);
    }
}