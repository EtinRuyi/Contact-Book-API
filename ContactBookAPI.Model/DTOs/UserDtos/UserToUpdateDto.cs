﻿using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.DTOs.UserDtos
{
    public class UserToUpdateDto
    {
        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(Email))]
        [EmailAddress]
        public string ConfirmEmail { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
