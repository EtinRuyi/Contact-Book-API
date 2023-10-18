using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ContactBookAPI.Commons.Helpers.ValidationHelpers
{
    public class AuthValidator
    {
        public static ValidationResult ValidateFirstnameLastnameCapitalized(string name, ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(name) && char.IsLower(name[0]))
            {
                return new ValidationResult("The name must start with a capital letter.");
            }
            return ValidationResult.Success;
        }

        public static ValidationResult ValidateEmailFormat(string email, ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(email) && !Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                return new ValidationResult("Invalid email address format.");
            }
            return ValidationResult.Success;
        }

        public static ValidationResult ValidatePasswordComplexity(string password, ValidationContext validationContext)
        {
            if (password.Length < 6)
            {
                return new ValidationResult("Password must be at least 6 characters long.");
            }

            if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=]).*$"))
            {
                return new ValidationResult("Password must contain at least 1 uppercase letter, 1 lowercase letter, 1 number, and 1 special character.");
            }

            return ValidationResult.Success;
        }
    }
}
