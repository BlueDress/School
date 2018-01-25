using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Models;

namespace ProductsShop.Data.EntityConfig
{
    public class CategoryProductConfig : IEntityTypeConfiguration<CategoryProduct>
    {
        public void Configure(EntityTypeBuilder<CategoryProduct> builder)
        {
            builder.HasKey(cp => new { cp.CategoryId, cp.ProductId });

            builder.HasOne(cp => cp.Category).WithMany(c => c.Products).HasForeignKey(cp => cp.CategoryId);

            builder.HasOne(cp => cp.Product).WithMany(p => p.Categories).HasForeignKey(cp => cp.ProductId);
        }
    }
}
