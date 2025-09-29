using ETicaret.Business.Abstract.Abstract.ETicaret;

namespace ETicaret.Business.Abstract.Abstract.GenericService;

public interface IGenericService
{
    ICategoryService CategoryService { get; }
    IProductImageService ProductImageService { get; }
    IProductService ProductService { get; }
    IBranchService BranchService { get; }
    IBrandService BrandService { get; }

}
