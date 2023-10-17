using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.DTOs
{
    public class AddUserRoleDto
    {
        [Required]
        public string Name { get; set; }
    }
}
