using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactBookAPI.Model.Entities;

namespace ContactBookAPI.Data
{
    public class ContactBookAPIDbContext : IdentityDbContext<User>
    {
        public ContactBookAPIDbContext(DbContextOptions<ContactBookAPIDbContext> options) : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}