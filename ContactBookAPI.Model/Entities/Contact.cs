using ContactBookAPI.Model.Entities.Shared;
using ContactBookAPI.Model.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Required]
        public string PhoneNumber { get; set; }
        public string PhotoUrl { get; set; }
        public Address Address { get; set; }
        [ForeignKey("UserId")]
        public string UserId { get; set; } 
        public User User { get; set; }
    }
}