using ContactBookAPI.Model.Enums;
using Microsoft.AspNetCore.Identity;

namespace ContactBookAPI.Model.Entities
{
    public class UserRole : IdentityRole
    {
        public UserRole() 
        { 
            Id = Guid.NewGuid().ToString();
        }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public bool IsDreprecated { get; set; }
    }
}
