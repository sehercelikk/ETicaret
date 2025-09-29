using ETicaret.DataAccess.Abstract;
using ETicaret.DataAccess.Concrete;
using ETicaret.DataAccess.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ETicaret.DataAccess.UnitOfWork.Concrete;

public class UnitfOfWorkETicaret : IUnitOfWorkETicaret
{
    private readonly DbContext _context;

    public UnitfOfWorkETicaret(DbContext context)
    {
        _context = context;
    }

    private EfCategoryRepository? _categoryRepository;
    private EfProductRepository? _productRepository;
    private EfProductImageRepository? _productImageRepository;
    private EfBranchRepository? _branchRepository;
    private EfBrandRepository? _brandRepository;

    public ICategoryDal CategoryDal => _categoryRepository ??= new EfCategoryRepository(_context);

    public IProductDal ProductDal => _productRepository ??= new EfProductRepository(_context);

    public IBranchDal BranchDal => _branchRepository ??= new EfBranchRepository(_context);

    public IBrandDal BrandDal => _brandRepository ??= new EfBrandRepository(_context);

    public IProductImageDal ProductImageDal => _productImageRepository ??= new EfProductImageRepository(_context);

    public async ValueTask DisposeAsync()=> await _context.DisposeAsync();

    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
}
