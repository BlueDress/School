using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarDealer.Data.Models;

namespace CarDealer.Data
{
    public class CarDealerDbContext : IdentityDbContext<User>
    {

        public CarDealerDbContext(DbContextOptions<CarDealerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartCar> PartCars { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PartCar>().HasKey(pc => new { pc.CarId, pc.PartId });

            builder.Entity<PartCar>().HasOne(pc => pc.Car).WithMany(c => c.Parts).HasForeignKey(pc => pc.CarId);

            builder.Entity<PartCar>().HasOne(pc => pc.Part).WithMany(p => p.Cars).HasForeignKey(pc => pc.PartId);

            builder.Entity<Part>().HasOne(p => p.Supplier).WithMany(s => s.Parts).HasForeignKey(p => p.SupplierId);

            builder.Entity<Sale>().HasOne(s => s.Customer).WithMany(c => c.Purchases).HasForeignKey(p => p.CustomerId);

            builder.Entity<Sale>().HasOne(s => s.Car).WithMany(c => c.Sales).HasForeignKey(s => s.CarId);

            base.OnModelCreating(builder);
        }
    }
}
