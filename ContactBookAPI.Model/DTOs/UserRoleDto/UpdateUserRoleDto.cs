using ContactBookAPI.Model.Enums;

namespace ContactBookAPI.Model.DTOs.UserRoleDto
{
    public class UpdateUserRoleDto
    {
        public UserRoleType NewRoleName { get; set; }
    }
}
