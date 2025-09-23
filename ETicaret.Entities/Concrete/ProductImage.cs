using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities.Concrete;

public class ProductImage : BaseEntity
{
    public string ImageUrl { get; set; }
    public string ProductId { get; set; }
    public Product Product { get; set; }
}
