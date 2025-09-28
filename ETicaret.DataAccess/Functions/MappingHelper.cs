using ETicaret.DataAccess.Mapping;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.DataAccess.Functions;

public static class MappingHelper
{
    public static void ETicaretInfo(this ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BranchMap());
        modelBuilder.ApplyConfiguration(new BrandMap());
        modelBuilder.ApplyConfiguration(new CategoryMap());
        modelBuilder.ApplyConfiguration(new ProductImageMap());
        modelBuilder.ApplyConfiguration(new ProductMap());
    }
}
