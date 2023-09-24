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
    public class BookConfig : BaseConfig<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.BookName).HasMaxLength(50);
            builder.HasOne(p => p.Category).WithMany(c => c.Books);
            builder.HasOne(p => p.Publisher).WithMany(pb => pb.Books);
            builder.HasOne(p => p.Reader).WithMany(r => r.Books);
            builder.HasOne(p => p.Staff).WithMany(s => s.Books);
            
        }
    }
}
