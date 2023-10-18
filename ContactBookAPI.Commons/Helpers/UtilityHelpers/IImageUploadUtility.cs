using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;

namespace ContactBookAPI.Commons.Helpers.UtilityHelpers
{
    public interface IImageUploadUtility
    {
        Task<ImageUploadResult> UploadUserImageAsync(string id, IFormFile image);
        Task<DeletionResult> DeleteUserImageAsync(string id, IFormFile image);
    }
}
