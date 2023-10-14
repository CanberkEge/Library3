using Library3.DAL.EntityConfig.Abstract;
using Library3.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.EntityConfig.Concrete
{
    public class CartConfig : BaseConfig<Cart>
    {
        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Quantity).HasDefaultValue(0);
            builder.Property(p => p.TotalPrice).HasColumnType("decimal(18, 2)");
            builder.Property(p => p.IsPaid).HasDefaultValue(false);

            builder.HasMany(p => p.Books).WithMany(p => p.Carts);
        }

    }
}
