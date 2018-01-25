using Microsoft.EntityFrameworkCore;

namespace FluffyDuffyMunchkinCats.Data
{
    public class CatsDbContext : DbContext
    {
        public CatsDbContext(DbContextOptions<CatsDbContext> options) : base(options)
        {
        }

        public DbSet<Cat> Cats { get; set; }
    }
}
