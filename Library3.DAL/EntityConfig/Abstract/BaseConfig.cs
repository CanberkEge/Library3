using Library3.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.EntityConfig.Abstract
{
    public abstract class BaseConfig<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)  
        {
            builder.HasKey(p=> p.Id);
            builder.Property(p=>p.CreateDate).HasDefaultValue(DateTime.Now);
        }
    }
}
