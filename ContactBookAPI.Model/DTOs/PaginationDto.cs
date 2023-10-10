using ContactBookAPI.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookAPI.Model.DTOs
{
    public class PaginationDto
    {
        public int count { get; set; }
        public int perPage { get; set; }
        public int CurrrentPage { get; set; }
        public IEnumerable<Contact> contacts { get; set; }
        public PaginationDto(int count, int perPage, int CurrentPage, IEnumerable<Contact> contacts)
        {
            this.count = count;
            this.perPage = perPage;
            this.CurrrentPage = CurrrentPage;
            this.contacts = contacts;
        }
    }
}
