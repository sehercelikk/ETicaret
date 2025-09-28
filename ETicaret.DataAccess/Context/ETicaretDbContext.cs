using ETicaret.DataAccess.Functions;
using ETicaret.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.DataAccess.Context;

public class ETicaretDbContext : IdentityDbContext<AppUser,AppRole,Guid>
{
    public ETicaretDbContext(DbContextOptions<ETicaretDbContext> options) : base(options){}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ETicaretInfo();
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<ProductImage> ProductImages { get; set; }
}
