using Library3.Entity.Abstract;
using Library3.Entity.Authentication;
using Library3.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.Context
{
    public class SqlDbContext : IdentityDbContext <AppUser, AppRole, string>

    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; } 
        public DbSet<Reader> Readers { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public SqlDbContext()
        {
            
        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=Library3Db3; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //public Task<int> DeleteAsync<T>(T entity) where T : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> InsertAsync<T>(T entity) where T : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> UpdateAsync<T>(T entity) where T : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<BaseEntity> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<T?> GetBy<T>(System.Linq.Expressions.Expression<Func<T, bool>> filter) where T : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ICollection<BaseEntity>> GetAllAsync()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IQueryable<T>> GetAllInclude<T>(System.Linq.Expressions.Expression<Func<T, bool>>? filter, System.Linq.Expressions.Expression<Func<T, object>>[] include) where T : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<ICollection<T>> GetAllAsync<T>(System.Linq.Expressions.Expression<Func<T, bool>>? filter) where T : BaseEntity
        //{
        //    throw new NotImplementedException();
        //}
    }
}
