using ETicaret.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Core.DataAccess.Abstract;

public interface IGenericDal<T> where T : class,IEntity, new()
{
    Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null,params Expression<Func<T, object>>[] expressions);
    Task<T> GetAsync(Expression<Func<T, bool>> expression=null,params Expression<Func<T,object>>[] expressions);
    Task<T> FindByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<bool> AnyAsync(Expression<Func<T, bool>> expression);


}
