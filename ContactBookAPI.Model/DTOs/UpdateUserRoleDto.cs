using ContactBookAPI.Model.Enums;

namespace ContactBookAPI.Model.DTOs
{
    public class UpdateUserRoleDto
    {
        public UserRoleType NewRole { get; set; }
    }
}
