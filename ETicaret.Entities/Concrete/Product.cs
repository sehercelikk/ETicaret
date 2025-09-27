using ETicaret.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities.Concrete;

public class Product : BaseEntity,IEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string BranchId { get; set; }
    public Branch Branch { get; set; } //Spor Dalı
    public string BrandId { get; set; } //Marka
    public Brand Brand { get; set; }
    //public List<OrderDetail> OrderDetails { get; set; }
    public List<ProductImage> ProductImages { get; set; }

}
