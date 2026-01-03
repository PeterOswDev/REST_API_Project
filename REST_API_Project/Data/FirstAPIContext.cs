using Microsoft.EntityFrameworkCore;
using REST_API_Project.Models;
using REST_API_Project.Data; 

namespace REST_API_Project.Data
{
    public class FirstAPIContext : DbContext
    {
        public FirstAPIContext(DbContextOptions<FirstAPIContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData
                (
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Author = "F.Scott Fitzgerald",
                    YearPublished = 1925

                },
                new Book
                {
                    Id = 2,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    YearPublished = 1960
                },
                new Book
                {
                    Id = 3,
                    Title = "1984",
                    Author = "George Orwell",
                    YearPublished = 1949
                },
                new Book
                {
                    Id = 4,
                    Title = "The Little Prince",
                    Author = "Antoine de Saint-Exupery",
                    YearPublished = 1943
                },
                new Book
                {
                    Id = 5,
                    Title = "The Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    YearPublished = 1954



                }










                );
        }

        public DbSet<Book> Books { get; set; }




        }
}
