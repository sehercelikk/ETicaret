using ETicaret.Entities.Abstract;

namespace ETicaret.Entities.Concrete;

public class Brand : BaseEntity, IEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }
}
