using ETicaret.Entities.Abstract;

namespace ETicaret.Entities.Concrete;

public class Branch : BaseEntity,IEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string CategoryId { get; set; }
    public Category Category { get; set; }
    public List<Product> Products { get; set; }
}
