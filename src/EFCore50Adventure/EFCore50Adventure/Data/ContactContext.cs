using EFCore50Adventure.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCore50Adventure.Data
{
    public class ContactContext : DbContext
    {
        public static readonly string RowVersion = nameof(RowVersion);
        public static readonly string ContactDb = nameof(ContactDb).ToLower();

        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .Property<byte[]>(RowVersion)
                .IsRowVersion();

            base.OnModelCreating(modelBuilder);
        }
    }
}
