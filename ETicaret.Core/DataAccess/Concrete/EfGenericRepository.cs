using ETicaret.Core.DataAccess.Abstract;
using ETicaret.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETicaret.Core.DataAccess.Concrete;

public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, IEntity, new()
{
    protected readonly DbContext _context;

    public EfGenericRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
    {
       return await _context.Set<TEntity>().AnyAsync(expression);
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
        return entity;
    }

    public async Task<TEntity> FindByIdAsync(int id)
    {
        return await _context.FindAsync<TEntity>(id);
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] expressions)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        if(predicate != null)
        {
            query = query.Where(predicate);
        }
        if(expressions != null)
        {
            if(expressions.Any())
            {
                foreach(var expr in expressions)
                {
                    query = query.Include(expr);
                }
            }
        }
        return await query.AsNoTracking().ToListAsync();)
    }

    public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] expressions)
    {
        IQueryable<TEntity> query= _context.Set<TEntity>();
        if(expression != null)
        {
            query = query.Where(expression);
        }
        if( expressions != null)
        {
            if(expressions.Any())
            {
                foreach(var expr in expressions)
                {
                    query = query.Include(expr);
                }
            }
        }
        return await query.AsNoTracking().FirstOrDefaultAsync();
    }

    public Task<TEntity> UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
