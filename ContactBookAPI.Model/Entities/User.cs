using Microsoft.AspNetCore.Identity;

namespace ContactBookAPI.Model.Entities
{
    public class User : IdentityUser
    {
        public Contact Contact { get; set; }
    }
}
