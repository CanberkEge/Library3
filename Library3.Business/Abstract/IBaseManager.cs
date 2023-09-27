using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Library3.DAL.Abstract;

namespace Library3.Business.Abstract
{
    public interface IBaseManager<T> where T : BaseEntity
    {
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);

        Task<T?> GetByIdAsync(int Id);
        Task<T?> GetBy(Expression<Func<T, bool>> filter);
        Task<ICollection<T>> GetAllAsync();
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null);
        Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include);
    }
}
