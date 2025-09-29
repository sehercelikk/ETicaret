namespace ETicaret.Dto.Concrete.SingleDto;

public class ProductDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string BranchId { get; set; }
    public string BrandId { get; set; }
    public bool IsActive { get; set; }
}
