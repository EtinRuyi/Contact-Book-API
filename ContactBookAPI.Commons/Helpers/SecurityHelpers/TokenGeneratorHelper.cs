using ContactBookAPI.Model.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace ContactBookAPI.Commons.Helpers.SecurityHelpers
{
    public class TokenGeneratorHelper : ITokenGeneratorHelper
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<User> _userManager;
        public TokenGeneratorHelper(IConfiguration configuration, UserManager<User> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }
        public Task<string> GenerateTokenAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
