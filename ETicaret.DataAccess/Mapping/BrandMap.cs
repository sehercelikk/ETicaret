using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Mapping;

public class BrandMap : IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
    {
        builder.HasKey(a => a.Id).HasName("Pk_Brand_Id");
        builder.Property(a => a.Id).HasMaxLength(60);

        builder.Property(a=>a.Name).IsRequired().HasMaxLength(60);

        builder.HasMany(a=>a.Products)
            .WithOne(b=>b.Brand)
            .HasForeignKey(b=>b.BrandId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
