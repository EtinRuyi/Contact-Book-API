using ContactBookAPI.Model.Entities.Shared;
using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.Entities
{
    public class Contact : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
        public Address Address { get; set; }
    }
}
