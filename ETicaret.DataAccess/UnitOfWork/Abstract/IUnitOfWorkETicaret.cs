using ETicaret.DataAccess.Abstract;

namespace ETicaret.DataAccess.UnitOfWork.Abstract;

public interface IUnitOfWorkETicaret : IAsyncDisposable
{
    ICategoryDal CategoryDal { get; }
    IProductDal ProductDal { get; }
    IBranchDal BranchDal { get; }
    IBrandDal BrandDal { get; }
    IProductImageDal ProductImageDal { get; }

    Task<int> SaveAsync();
}
