using ETicaret.Entities.Abstract;

namespace ETicaret.Entities.Concrete;

public class Category : BaseEntity,IEntity
{
    public string Name { get; set; }
    public List<Branch> Branches { get; set; }
}
