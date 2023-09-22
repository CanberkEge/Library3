using Library3.Business.Abstract;
using Library3.DAL.Abstract;
using Library3.DAL.Context;
using Library3.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library3.Business.Concrete
{
    public class BaseManager<T> : IBaseManager<T> where T : BaseEntity
    {


        public SqlDbContext dbContext { get; set; }

        public BaseManager()
        {

            this.dbContext = new SqlDbContext();

        }

        #region Insert
        public virtual async Task<int> InsertAsync(T entity)
        {

            return await dbContext.InsertAsync(entity);
        }
        #endregion

        #region Update
        public virtual async Task<int> UpdateAsync(T entity)
        {
            return await dbContext.UpdateAsync(entity);
        }
        #endregion

        #region Delete
        public async Task<int> DeleteAsync(T entity)
        {
            return await dbContext.DeleteAsync(entity);
        }
        #endregion

        #region GetByIdAsync
        public async Task<T?> GetByIdAsync(int id)
        {
            return (T?)await dbContext.GetByIdAsync(id);
        }
        #endregion

        #region GetBy
        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await dbContext.GetBy(filter);
        }
        #endregion

        #region GetAllAsync
        public async Task<ICollection<T>> GetAllAsync()
        {
            return (ICollection<T>)await dbContext.GetAllAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return await dbContext.GetAllAsync(filter);
        }
        #endregion

        #region GetAllInclude
        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            return await dbContext.GetAllInclude(filter, include);
        }
        #endregion
    }
}
