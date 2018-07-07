using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewsSystem.Data.Models;

namespace NewsSystem.Data
{
    public class NewsSystemDbContext : IdentityDbContext<User>
    {
        public NewsSystemDbContext(DbContextOptions<NewsSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Article>().HasOne(a => a.Author).WithMany(u => u.Articles).HasForeignKey(a => a.AuthorId);

            builder.Entity<Article>().HasOne(a => a.Category).WithMany(c => c.Articles).HasForeignKey(a => a.CategoryId);

            base.OnModelCreating(builder);
        }
    }
}
