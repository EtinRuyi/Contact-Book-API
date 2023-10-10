using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.DTOs
{
    public class UserToAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [DataType(DataType.Password)]
        public string PassWord { get; set; }
        public string Role { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
