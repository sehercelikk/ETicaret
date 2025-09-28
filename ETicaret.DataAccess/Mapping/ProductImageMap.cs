using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccess.Mapping;

internal class ProductImageMap : IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> builder)
    {
        builder.HasKey(a => a.Id).HasName("Pk_PIamge_Id");
        builder.Property(a => a.Id).HasMaxLength(60);

        builder.Property(a => a.ImageUrl).IsRequired();
        builder.Property(a=>a.ProductId).IsRequired();
    }
}
