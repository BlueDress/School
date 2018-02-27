using CameraBazaar.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CameraBazaar.Data
{
    public class CameraBazaarDbContext : IdentityDbContext<User>
    {
        public DbSet<Camera> Cameras { get; set; }

        public CameraBazaarDbContext(DbContextOptions<CameraBazaarDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Camera>().HasOne(c => c.User).WithMany(u => u.AddedCameras).HasForeignKey(c => c.UserID);

            base.OnModelCreating(builder);
        }
    }
}
