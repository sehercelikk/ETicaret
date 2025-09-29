using ETicaret.Entities.Abstract;

namespace ETicaret.Entities.Concrete;

public class ProductImage : BaseEntity, IEntity
{
    public string ImageUrl { get; set; }
    public string ProductId { get; set; }
    public Product Product { get; set; }
}
