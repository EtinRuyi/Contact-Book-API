using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using ContactBookAPI.Model;
using ContactBookAPI.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace ContactBookAPI.Commons.Helpers.UtilityHelpers
{
    public class ImageUploadUtility : IImageUploadUtility
    {
        private readonly UserManager<User> _userManager;
        private readonly Cloudinary _cloudinary;
        public ImageUploadUtility(UserManager<User> userManager, IOptions<ImageConfiguration> cloudinaryConfig) 
        { 
            _userManager = userManager;

            var acct = new Account(
                cloudinaryConfig.Value.CloudName,
                cloudinaryConfig.Value.ApiKey,
                cloudinaryConfig.Value.ApiSecret);
            _cloudinary = new Cloudinary(acct);
        }
        public Task<DeletionResult> DeleteUserImageAsync(string id, IFormFile image)
        {
            throw new NotImplementedException();
        }

        public Task<ImageUploadResult> UploadUserImageAsync(string id, IFormFile image)
        {
            throw new NotImplementedException();
        }
    }
}
