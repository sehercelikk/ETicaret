using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccess.Mapping;

public class BranchMap : IEntityTypeConfiguration<Branch>
{
    public void Configure(EntityTypeBuilder<Branch> builder)
    {
        builder.HasKey(x => x.Id).HasName("Pk_Branch_Id");
        builder.Property(a => a.Id).HasMaxLength(60);

        builder.Property(a=>a.Name).IsRequired().HasMaxLength(60);
        builder.Property(a => a.Description).IsRequired();
        builder.Property(a => a.CategoryId).IsRequired();

        builder.HasMany(a=>a.Products)
            .WithOne(b=>b.Branch)
            .HasForeignKey(a=>a.BranchId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
