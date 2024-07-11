using BookListApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookListApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Harry Potter and the Philosopher's Stone", Author = "J. K. Rowling", PublishedYear = 1960 },
                new Book { Id = 2, Title = "Tom Jones", Author = "Henry Fielding", PublishedYear = 1749 },
                new Book { Id = 3, Title = "The Hobbit", Author = "J. R. R. Tolkien", PublishedYear = 1980 }
            );
        }
    }
}