using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccess.Mapping;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(a => a.Id).HasName("Pk_Category_Id");
        builder.Property(a => a.Id).HasMaxLength(60);

        builder.Property(a=>a.Name).IsRequired().HasMaxLength(60);

        builder.HasMany(a => a.Branches)
            .WithOne(b => b.Category)
            .HasForeignKey(a => a.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
