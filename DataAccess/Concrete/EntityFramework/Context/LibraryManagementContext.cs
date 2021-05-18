using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class LibraryManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=WINDOWS-BU3UHI4\SQLEXPRESS;Database=LibraryManagement;trusted_connection=true;");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Librarian> Librarians { get; set; }
        public DbSet<IssueBook> IssueBooks { get; set; }
        public DbSet<ReturnBook> ReturnBooks { get; set; }
    }
}