using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Mapping;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id).HasName("Pk_Product_Id");
        builder.Property(a => a.Id).HasMaxLength(60);

        builder.Property(a=>a.Name).IsRequired().HasMaxLength(60);
        builder.Property(a=>a.Price).IsRequired();
        builder.Property(a=>a.BranchId).IsRequired();
        builder.Property(a=>a.BranchId).IsRequired();
        builder.Property(a=>a.Stock).IsRequired();
        builder.Property(a=>a.Description).IsRequired();

        builder.HasMany(a=>a.ProductImages)
            .WithOne(b=>b.Product)
            .HasForeignKey(a=>a.ProductId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
