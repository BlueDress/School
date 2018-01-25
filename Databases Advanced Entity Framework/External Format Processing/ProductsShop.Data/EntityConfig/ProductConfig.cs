using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Models;

namespace ProductsShop.Data.EntityConfig
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().IsUnicode().HasMaxLength(255);

            builder.Property(p => p.Price).IsRequired();

            builder.Property(p => p.BuyerId).IsRequired(false);

            builder.Property(p => p.SellerId).IsRequired();

            builder.HasOne(p => p.Seller).WithMany(u => u.ProductsSold).HasForeignKey(p => p.SellerId);

            builder.HasOne(p => p.Buyer).WithMany(u => u.ProductsBought).HasForeignKey(p => p.BuyerId);
        }
    }
}
