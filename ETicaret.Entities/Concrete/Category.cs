namespace ETicaret.Entities.Concrete;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Branch> Branches { get; set; }
}
