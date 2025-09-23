using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Entities.Concrete;

public class Branch : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string CategoryId { get; set; }
    public Category Category { get; set; }
}
