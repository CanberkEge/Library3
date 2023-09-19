using Library3.DAL.Abstract;
using Library3.DAL.Context;
using Library3.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public SqlDbContext dbContext { get; set; }
        public BaseRepository()  
        {
            this.dbContext = new SqlDbContext();
        }

        #region Insert
        public virtual async Task<int> InsertAsync(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Update
        public virtual async Task<int> UpdateAsync(T entity)
        {
            dbContext.Set<T>().Update(entity);
            return await dbContext.SaveChangesAsync();
        }
        #endregion

        #region Delete
        public async Task<int> DeleteAsync(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return await dbContext.SaveChangesAsync();
        }
        #endregion

        #region GetByIdAsync
        public async Task<T?> GetByIdAsync(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
        #endregion

        #region GetBy
        public async Task<T?> GetBy(Expression<Func<T, bool>> filter)
        {
            return await dbContext.Set<T>().Where(filter).FirstOrDefaultAsync();
        }
        #endregion

        #region GetAllAsync
        public async Task<ICollection<T>> GetAllAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null)
        {
            if (filter == null)
            {
                return await dbContext.Set<T>().ToListAsync();
            }
            return await dbContext.Set<T>().Where(filter).ToListAsync();
        }
        #endregion

        #region GetAllInclude
        public async Task<IQueryable<T>> GetAllInclude(Expression<Func<T, bool>>? filter = null, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;
            if (filter != null)
            {
                query = dbContext.Set<T>().Where(filter);
            }
            else
            {
                query = dbContext.Set<T>();
            }
            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
        #endregion


    }
}
