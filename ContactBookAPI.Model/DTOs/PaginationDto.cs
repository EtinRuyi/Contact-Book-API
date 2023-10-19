using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Model.DTOs
{
    public class PaginationDto
    {
        public int TotalUsers { get; set; }
        public int PageSize { get; set; }
        public int CurrrentPage { get; set; }
        public List<User> Users { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}