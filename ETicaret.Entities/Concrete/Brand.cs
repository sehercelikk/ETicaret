using ETicaret.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities.Concrete;

public class Brand : BaseEntity, IEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
