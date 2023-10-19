using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.DTOs.UserRoleDto
{
    public class AddUserRoleDto
    {
        [Required]
        public string Name { get; set; }
    }
}
