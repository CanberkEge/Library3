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
using Microsoft.EntityFrameworkCore;
using Library3.DAL.Concrete;

namespace Library3.Business.Concrete
{
    public class BaseManager<T> : IBaseManager<T> where T : BaseEntity
    {

        private readonly IBaseRepository<T> repository;
        
        

        public BaseManager()                           
        {

            
            this.repository =  new BaseRepository<T>();
        }
        
        #region Insert
        public virtual async Task<int> InsertAsync(T entity)
        {

            return await repository.InsertAsync(entity);
        }
        #endregion

        #region Update
        public virtual async Task<int> UpdateAsync(T entity)
        {
            return await repository.UpdateAsync(entity);
        }
        #endregion

        #region Delete
        public async Task<int> DeleteAsync(T entity)
        {
            return await repository.DeleteAsync(entity);
        }
        #endregion

        #region GetByIdAsync
        public async Task<T?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync(id);
        }
        #endregion

        #region GetBy
        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await repository.GetBy(filter);
        }
        #endregion

        #region GetAllAsync
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            return await repository.GetAllAsync(filter);
        }
        #endregion

        #region GetAllInclude
        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            return await repository.GetAllInclude(filter, include);
        }
        #endregion
    }
}
