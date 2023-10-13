using Library3.DAL.EntityConfig.Abstract;
using Library3.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.EntityConfig.Concrete
{
    public class SaleConfig : BaseConfig<Sale>

    {
        public override void Configure(EntityTypeBuilder<Sale> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.DiscountRate).HasColumnType("decimal(18, 2)");
            builder.Property(p => p.StartDate);
            builder.Property(p => p.EndDate);

            builder.HasOne(p => p.Book).WithMany(p => p.Sales);
        }
    }
}
