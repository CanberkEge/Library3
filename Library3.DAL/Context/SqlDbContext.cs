using Library3.Entity.Concrete;
using Library3.Entity.Identities;
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
    public class SqlDbContext : IdentityDbContext<MyUser>
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
            optionsBuilder.UseSqlServer(@"Server=localhost; Database=Library3Db; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
