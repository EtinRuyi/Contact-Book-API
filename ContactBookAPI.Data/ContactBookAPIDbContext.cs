using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Data
{
    public class ContactBookAPIDbContext : IdentityDbContext<User>
    {
        private readonly DbContextOptions _option;
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public ContactBookAPIDbContext()
        {

        }
        public ContactBookAPIDbContext(DbContextOptions<ContactBookAPIDbContext> options) : base(options)
        {
            _option = options;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}