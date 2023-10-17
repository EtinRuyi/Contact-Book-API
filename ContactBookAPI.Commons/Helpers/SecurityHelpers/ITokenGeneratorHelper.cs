using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Commons.Helpers.SecurityHelpers
{
    public interface ITokenGeneratorHelper
    {
        Task<string> GenerateTokenAsync(User user);
    }
}