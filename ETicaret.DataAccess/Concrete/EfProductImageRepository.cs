using ETicaret.Core.DataAccess.Concrete;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.DataAccess.Concrete;

public class EfProductImageRepository : EfGenericRepository<ProductImage>, IProductImageDal
{
    public EfProductImageRepository(DbContext context) : base(context)
    {
    }
}
