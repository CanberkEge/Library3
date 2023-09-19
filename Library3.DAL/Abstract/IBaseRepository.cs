using Library3.DAL.Context;
using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.Abstract
{
    public interface IBaseRepository <T> where T : BaseEntity
    {
        public SqlDbContext dbContext { get; set; }
        Task<int> InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);

        Task<T?> GetByIdAsync(int id);
        Task<T?> GetBy(Expression<Func<T, bool>> filter);
    }
}
