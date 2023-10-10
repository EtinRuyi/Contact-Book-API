using ContactBookAPI.Model.Entities.Shared;
using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Model.Entities
{
    public class Address : BaseEntity
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Country { get; set; }
    }
}
