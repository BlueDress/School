using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsShop.Models;

namespace ProductsShop.Data.EntityConfig
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName).IsRequired(false).IsUnicode().HasMaxLength(30);

            builder.Property(u => u.LastName).IsRequired().IsUnicode().HasMaxLength(30);

            builder.Property(u => u.Age).IsRequired(false);
        }
    }
}
