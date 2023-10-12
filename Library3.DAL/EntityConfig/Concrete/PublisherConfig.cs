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
    public class PublisherConfig : BaseConfig<Publisher>

    {
        public override void Configure(EntityTypeBuilder<Publisher> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.PublisherName).HasMaxLength(128);
            builder.HasMany(p => p.Books).WithOne(pb => pb.Publisher);
            builder.Property(p=> p.PublishYear).HasMaxLength(4);
        }
    }
}
