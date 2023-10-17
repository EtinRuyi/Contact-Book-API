using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Model.DTOs
{
    public class PaginationDto
    {
        public int Count { get; set; }
        public int PageSize { get; set; }
        public int CurrrentPage { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }
        //public PaginationDto(int count, int perPage, int CurrentPage, IEnumerable<Contact> contacts)
        //{
        //    this.Count = count;
        //    this.PageSize = perPage;
        //    this.CurrrentPage = CurrrentPage;
        //    this.Contacts = contacts;
        //}
    }
}