using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-PAU4AHF\\SQLEXPRESS;Database=CodingWiki;TrustServerCertificate=True;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(b => b.Price).HasPrecision(10,5);
       
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "C# Basics", ISBN = "123-4567890123", Price = 19.99M },
                new Book { BookId = 2, Title = "ASP.NET Core Guide", ISBN = "123-4567890124", Price = 39.99M }
            );

            var booklist = new Book[]
            {
                   new Book { BookId = 3, Title = "C# Basics3", ISBN = "123-4567890123", Price = 20.99M },
                      new Book { BookId = 4, Title = "C# Basics4", ISBN = "123-4567890123", Price = 29.99M },
                         new Book { BookId = 5, Title = "C# Basics5", ISBN = "123-4567890123", Price = 39.99M },
            };
            modelBuilder.Entity<Book>().HasData(booklist);

        }


    }
}
