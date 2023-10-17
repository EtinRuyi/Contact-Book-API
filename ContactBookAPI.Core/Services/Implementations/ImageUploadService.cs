using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using ContactBookAPI.Core.Services.Interface;
using ContactBookAPI.Model;
using ContactBookAPI.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace ContactBookAPI.Core.Services.Implementations
{
    public class ImageUploadService : IImageUploadService
    {
        private readonly UserManager<User> _userManager;
        private readonly Cloudinary _cloudinary;
        public ImageUploadService(UserManager<User> userManager, IOptions<ImageConfiguration> cloudinaryConfig) 
        {
            _userManager = userManager;

            var account = new Account(
            cloudinaryConfig.Value.CloudName,
            cloudinaryConfig.Value.ApiKey,
            cloudinaryConfig.Value.ApiSecret);

            _cloudinary = new Cloudinary(account);
        }

        public Task<DeletionResult> DeleteUserImageAsync(string id, IFormFile image)
        {
            throw new NotImplementedException();
        }

        Task<ImageUploadResult> IImageUploadService.UploadUserImageAsync(string id, IFormFile image)
        {
            throw new NotImplementedException();
        }
    }
}
