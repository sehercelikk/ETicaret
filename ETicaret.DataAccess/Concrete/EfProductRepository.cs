using ETicaret.Core.DataAccess.Concrete;
using ETicaret.DataAccess.Abstract;
using ETicaret.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccess.Concrete;

public class EfProductRepository : EfGenericRepository<Product>, IProductDal
{
    public EfProductRepository(DbContext context) : base(context)
    {
    }
}
