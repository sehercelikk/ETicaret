using ETicaret.Core.DataAccess.Concrete;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.DataAccess.Concrete;

public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryDal
{
    public EfCategoryRepository(DbContext context) : base(context)
    {
    }
}
