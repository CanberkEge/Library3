using Library3.DAL.EntityConfig.Abstract;
using Library3.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.EntityConfig.Concrete
{
    public class CategoryConfig : BaseConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.CategoryName).HasMaxLength(50);
            builder.HasMany(p => p.Books).WithOne(c => c.Category);
        }
    }
}
