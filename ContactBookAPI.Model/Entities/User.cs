using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactBookAPI.Model.Entities
{
    public class User : IdentityUser
    {
        [ForeignKey("ContactId")]
        public string ContactId { get; set; }
        public ICollection<Contact> Contact { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;
        public bool IsDreprecated { get; set; }
    }
}
