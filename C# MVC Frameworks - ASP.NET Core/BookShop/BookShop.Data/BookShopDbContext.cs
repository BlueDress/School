using BookShop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BookShop.Data
{
    public class BookShopDbContext : DbContext
    {
        public BookShopDbContext(DbContextOptions<BookShopDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBook> CategoryBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);

            builder.Entity<CategoryBook>().HasKey(cb => new { cb.CategoryId, cb.BookId });

            builder.Entity<CategoryBook>().HasOne(cb => cb.Category).WithMany(c => c.Books).HasForeignKey(cb => cb.CategoryId);

            builder.Entity<CategoryBook>().HasOne(cb => cb.Book).WithMany(b => b.Categories).HasForeignKey(cb => cb.BookId);
        }
    }
}
