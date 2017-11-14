using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data.Models;
using System.IO;

namespace P03_SalesDatabase.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext()
        {

        }

        public SalesContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = File.ReadAllText("C:\\Program Files (x86)\\Notepad++\\Instructions.txt");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(e =>
            {
                e.HasKey(p => p.ProductId);

                e.Property(p => p.Name).IsRequired().IsUnicode().HasMaxLength(50);

                e.Property(p => p.Quantity).IsRequired();

                e.Property(p => p.Price).IsRequired();

                e.Property(p => p.Description).IsRequired().HasMaxLength(250).HasDefaultValue("No description");
            });

            modelBuilder.Entity<Customer>(e =>
            {
                e.HasKey(c => c.CustomerId);

                e.Property(c => c.Name).IsRequired().IsUnicode().HasMaxLength(100);

                e.Property(c => c.Email).IsUnicode(false).HasMaxLength(80);

                e.Property(c => c.CreditCardNumber).IsRequired();
            });

            modelBuilder.Entity<Store>(e =>
            {
                e.HasKey(s => s.StoreId);

                e.Property(s => s.Name).IsRequired().IsUnicode().HasMaxLength(80);
            });

            modelBuilder.Entity<Sale>(e =>
            {
                e.HasKey(s => s.SaleId);

                e.Property(s => s.Date).IsRequired().HasColumnType("DATETIME2").HasDefaultValueSql("GETDATE()");

                e.HasOne(s => s.Product).WithMany(p => p.Sales).HasForeignKey(s => s.ProductId);

                e.HasOne(s => s.Customer).WithMany(c => c.Sales).HasForeignKey(s => s.CutomerId);

                e.HasOne(s => s.Store).WithMany(s => s.Sales).HasForeignKey(s => s.StoreId);
            });
        }
    }
}
