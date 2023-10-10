using ContactBookAPI.Commons.Helpers;
using ContactBookAPI.Model.Entities.Shared;
using ContactBookAPI.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.Entities
{
    public class Contact : BaseEntity
    {
        [Required]
        [CustomValidation(typeof(ValidationHelper), "ValidateFirstnameLastnameCapitalized")]
        public string FirstName { get; set; }

        [Required]
        [CustomValidation(typeof(ValidationHelper), "ValidateFirstnameLastnameCapitalized")]
        public string LastName { get; set; }

        [Required]
        [CustomValidation(typeof(ValidationHelper), "ValidateEmailFormat")]
        public string Email { get; set; }

        public string PhotoUrl { get; set; }

        public Address Address { get; set; }

        [Required]
        public UserRole UserRole { get; set; }

        //[Required]
        //[CustomValidation(typeof(ValidationHelper), "ValidatePasswordComplexity")]
        //public string Password { get; set; }
    }
}
